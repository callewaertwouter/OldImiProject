using Imi.Project.Mobile.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services
{
    public interface IRecipeService
    {
        Task<Recipe> GetRecipe(Guid id);

        Task<Recipe> GetAllRecipes();

        Task<Recipe> AddRecipe();

        Task<Recipe> UpdateRecipe(Recipe recipe);

        Task<Recipe> DeleteRecipe(Guid id);

        //TODO: Maybe another method to get all recipes from one user
    }
}