using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class ApiRecipesService : IRecipeService
    {
        private string baseUri = Constants.BaseUrl;
        protected IWebApiClient _webApiClient;
        public ApiRecipesService(IWebApiClient client)
        {
            _webApiClient = client;
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            var recipesApi = _webApiClient.GetApiResult<IEnumerable<Recipe>>($"{baseUri}/recipes");

            var recipes = new List<Recipe>();
            recipes.AddRange((IEnumerable<Recipe>)recipesApi);

            return recipes.OrderBy(recipe => recipe.Title);
        }

        public Recipe GetRecipe(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> AddRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> DeleteRecipe(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
