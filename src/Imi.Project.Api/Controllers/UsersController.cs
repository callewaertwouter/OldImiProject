using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.Recipe;
using Imi.Project.Api.Core.DTOs.User;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        protected readonly IUserRepository _userRepository;
        protected readonly IRecipeRepository _recipeRepository;

        public UsersController(IUserRepository userRepository,
                               IRecipeRepository recipeRepository)
        {
            _userRepository = userRepository;
            _recipeRepository = recipeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.ListAllAsync();
            var usersDto = users.Select(r => new UserResponseDto
            {
                Id = r.Id,
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
                Id = user.Id,
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
                    Id = r.User.Id,
                    Email = r.User.Email
                }
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