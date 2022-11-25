using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.Recipe;
using Imi.Project.Api.Core.DTOs.UnitOfMeasure;
using Imi.Project.Api.Core.DTOs.User;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var recipes = await _recipeRepository.ListAllAsync();
            var recipesDto = recipes.Select(r => new RecipeResponseDto
            {
                Id = r.Id,
                Title = r.Title,
                Description = r.Description,
                Ingedrients = r.Ingedrients.Select(i => new IngedrientResponseDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    // //System.NullReferenceException: 'Object reference not set to an instance of an object.'
                    MeasureUnit = new UnitOfMeasureResponseDto
                    {
                        MeasureUnit = i?.UnitOfMeasure?.MeasureUnit
                    }
                }).ToList(),
                CreatedByUser = new UserResponseDto
                {
                    Email = r.User.Email
                }
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
                Title = recipe.Title,
                Description = recipe.Description,
                CreatedByUser = new UserResponseDto
                {
                    Email = recipe.User.Email
                }
            };

            return Ok(recipeDto);
        }

        [Authorize(Policy = "Over15Only")]
        [HttpPost]
        public async Task<IActionResult> Add(RecipeRequestDto recipeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var recipeEntity = new Recipe
            {
                Title = recipeDto.Title,
                Description = recipeDto.Description,
                Ingedrients = (ICollection<Ingedrient>)recipeDto.Ingedrients.ToList(),
                UserId = recipeDto.CreatedBy.Id.ToString()
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
            recipeEntity.Description = recipeDto.Description;
            recipeEntity.Ingedrients = (ICollection<Ingedrient>)recipeDto.Ingedrients.ToList();

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