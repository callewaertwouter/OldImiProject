using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.Recipe;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        protected readonly IRecipeRepository _recipeRepository;
        protected readonly IIngedrientRepository _ingedrientRepository;

        public RecipesController(IRecipeRepository recipeRepository, 
                                 IIngedrientRepository ingedrientRepository)
        {
            _recipeRepository = recipeRepository;
            _ingedrientRepository = ingedrientRepository;
        }

        //TODO Recipes and ingedrients are many-to-many relationship. Need to figure out how to get all ingedrients for each recipe
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var recipes = await _recipeRepository.ListAllAsync();
            var recipesDto = recipes.Select(r => new RecipeResponseDto
            {
                Id = r.Id,
                Title = r.Title
            });

            return Ok(recipesDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var recipe = await _recipeRepository.GetByIdAsync(id);

            if (recipe == null)
            {
                return NotFound($"No recipe with an id of {id}.");
            }

            var recipeDto = new RecipeResponseDto
            {
                Id = recipe.Id,
                Title = recipe.Title
            };

            return Ok(recipeDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(RecipeRequestDto recipeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var recipeEntity = new Recipe
            {
                Title = recipeDto.Title
            };

            await _recipeRepository.AddAsync(recipeEntity);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(RecipeRequestDto recipeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var recipeEntity = await _recipeRepository.GetByIdAsync(recipeDto.Id);

            if (recipeEntity == null)
            {
                return NotFound($"No recipe with an id of {recipeDto.Id}");
            }

            recipeEntity.Title = recipeDto.Title;

            await _recipeRepository.UpdateAsync(recipeEntity);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var recipeEntity = await _recipeRepository.GetByIdAsync(id);

            if (recipeEntity == null)
            {
                return NotFound($"No recipe with an id of {id}");
            }

            await _recipeRepository.DeleteAsync(recipeEntity);

            return Ok();
        }
    }
}