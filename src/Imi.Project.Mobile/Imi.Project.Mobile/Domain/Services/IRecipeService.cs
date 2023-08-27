using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services
{
    public interface IRecipeService
    {
        Task<Recipe> GetRecipe(Guid id);

        Task<IEnumerable<Recipe>> GetRecipes();

        Task<Recipe> AddRecipe(Recipe recipe);

        Task<Recipe> UpdateRecipe(Recipe recipe);

        Task<Recipe> DeleteRecipe(Guid id);
    }
}