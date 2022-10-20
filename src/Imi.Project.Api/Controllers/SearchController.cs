using Imi.Project.Api.Core.DTOs.Recipe;
using Imi.Project.Api.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUserRepository _userRepository;

        public SearchController(IRecipeRepository recipeRepository, 
                                IUserRepository userRepository)
        {
            _recipeRepository = recipeRepository;
            _userRepository = userRepository;
        }

        //TODO Think about whether or showing ingedrients is necessary for a searchresult
        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] string searchQuery)
        {
            var searchResults = await _recipeRepository.SearchAsync(searchQuery);

            var searchResultsDto = searchResults.Select(s => new RecipeResponseDto
            {
                Id = s.Id,
                Title = s.Title
            });

            return Ok(searchResultsDto);
        }
    }
}