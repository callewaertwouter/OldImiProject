using Imi.Project.Api.Core.DTOs.Recipe;
using Imi.Project.Api.Core.DTOs.User;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        protected readonly IUserRepository _userRepository;
        protected readonly IRecipeRepository _recipeRepository;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<User> _signInManager;

        public UsersController(IUserRepository userRepository,
                               IRecipeRepository recipeRepository,
                               UserManager<User> userManager,
                               IConfiguration configuration,
                               SignInManager<User> signInManager)
        {
            _userRepository = userRepository;
            _recipeRepository = recipeRepository;
            _userManager = userManager;
            _configuration = configuration;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpPost("auth/register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequestDto registration)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            User newUser = new User
            {
                Email = registration.Email,
                UserName = registration.Username,
                Birthday = registration.Birthday
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, registration.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            newUser = await _userManager.FindByEmailAsync(registration.Email);
            await _userManager.AddClaimAsync(newUser, new Claim("registration-date", DateTime.UtcNow.ToString("yy-MM-dd")));

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("auth/login")]
        public async Task<IActionResult> Login([FromBody] LoginUserRequestDto login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                return Unauthorized();
            }

            var user = await _userManager.FindByEmailAsync(login.Email);
            JwtSecurityToken token = await GenerateTokenAsync(user);

            string serializedToken = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new LoginUserResponseDto()
            {
                Token = serializedToken,
            });
        }

        private async Task<JwtSecurityToken> GenerateTokenAsync(User user)
        {
            //var claims = new List<Claim>{
            //    new Claim(JwtRegisteredClaimNames.Birthdate, user.Birthday.ToString()),
            //    new Claim(JwtRegisteredClaimNames.Email, user.Email),
            //    new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName)
            //};

            var claims = new List<Claim>();

            var userClaims = await _userManager.GetClaimsAsync(user);

            claims.AddRange(userClaims);

            var roleClaims = await _userManager.GetRolesAsync(user);
            foreach (var roleClaim in roleClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleClaim));
            }

            var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays");
            var signInKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigninKey"));

            var token = new JwtSecurityToken
                (
                    issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                    audience: _configuration.GetValue<string>("JWTConfigration:Audience"),
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(signInKey), SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.ListAllAsync();
            var usersDto = users.Select(r => new UserResponseDto
            {
                Email = r.Email
            });

            return Ok(usersDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound($"No user with an id of {id}.");
            }

            var userDto = new UserResponseDto
            {
                Id = Guid.Parse(user.Id),
                Email = user.Email
            };

            return Ok(userDto);
        }

        [HttpGet("{userId}/recipes")]
        public async Task<IActionResult> GetRecipesFromUserId(Guid userId)
        {
            var recipes = await _recipeRepository.GetByUserIdAsync(userId);

            var recipesDto = recipes.Select(r => new RecipeResponseDto
            {
                Id = r.Id,
                Title = r.Title,
                CreatedByUser = new UserResponseDto
                {
                    Email = r.User.Email
                }
                // Could also get the description and list of ingedrients but that might get too cluttery so we make do with just ID, Title and User Email
            });

            return Ok(recipesDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserRequestDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var userEntity = new User
            {
                Id = Guid.NewGuid().ToString(), // Since it's a new user, an ID does not exists yet so an ID needs to be created
                Email = userDto.Email
            };

            await _userRepository.AddAsync(userEntity);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserRequestDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var userEntity = await _userRepository.GetByIdAsync(userDto.Id);

            if (userEntity == null)
            {
                return NotFound($"No user with an id of {userDto.Id}");
            }

            userEntity.Email = userDto.Email;
            //TODO Check if list of recipes also require an update (no property added for such in UserRequestDto yet)

            await _userRepository.UpdateAsync(userEntity);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var userEntity = await _userRepository.GetByIdAsync(id);

            if (userEntity == null)
            {
                return NotFound($"No user with an id of {id}");
            }

            await _userRepository.DeleteAsync(userEntity);

            return Ok();
        }
    }
}