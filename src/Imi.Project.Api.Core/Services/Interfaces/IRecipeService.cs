using Imi.Project.Api.Core.Services.Models.RecipeService;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Interfaces
{
    public interface IRecipeService
    {
        Task<ViewRecipesResult> GetAllRecipes();
        Task<ViewRecipesResult> GetRecipeById(Guid id);
        Task<ViewRecipesResult> SearchRecipeByName(string searchInput);
    }
}