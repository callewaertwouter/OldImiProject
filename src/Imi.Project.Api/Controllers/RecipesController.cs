﻿using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.Recipe;
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

        [HttpGet]
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
    }
}