using Imi.Project.Api.Core.DTOs.User;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
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

        //TODO Figure how to show get all recipes created by each user (one-to-many relationship)
        // A recipe can be created by only one user, but one user can create many recipes
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

        [HttpGet]
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
    }
}