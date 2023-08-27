using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
	public class ApiRecipesService : IRecipeService
	{
		private string baseUri = Constants.BaseUrl;
		protected IWebApiClient _webApiClient;
		private readonly IRecipeService _mockService;

		public ApiRecipesService(IWebApiClient client, 
								 IRecipeService mockService)
		{
			_webApiClient = client;
			_mockService = mockService;
		}

		public async Task<IEnumerable<Recipe>> GetRecipes()
		{
			try
			{
				var recipes = await _webApiClient.GetApiResult<IEnumerable<Recipe>>($"{baseUri}/recipes");
				return recipes.OrderBy(recipe => recipe.Title);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				return await _mockService.GetRecipes();
			}
		}

		public async Task<Recipe> GetRecipe(Guid id)
		{
			try
			{
				var recipe = await _webApiClient.GetApiResult<Recipe>($"{baseUri}/recipes/{id}");
				return recipe;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				return await _mockService.GetRecipe(id);
			}
		}

		public async Task<Recipe> AddRecipe(Recipe recipe)
		{
			try
			{
				var createdRecipe = await _webApiClient.PostCallApi<Recipe, Recipe>($"{baseUri}/recipes", recipe);
				return createdRecipe;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				return await _mockService.AddRecipe(recipe);
			}
		}

		public async Task<Recipe> UpdateRecipe(Recipe recipe)
		{
			try
			{
				var updatedRecipe = await _webApiClient.PutCallApi<Recipe, Recipe>($"{baseUri}/recipes/{recipe.Id}", recipe);
				return updatedRecipe;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				return await _mockService.UpdateRecipe(recipe);
			}
		}

		public async Task<Recipe> DeleteRecipe(Guid id)
		{
			try
			{
				var deletedRecipe = await _webApiClient.DeleteCallApi<Recipe>($"{baseUri}/recipes/{id}");
				return deletedRecipe;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				return await _mockService.DeleteRecipe(id);
			}
		}
	}
}