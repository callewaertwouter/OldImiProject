using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockRecipeService : IRecipeService
    {
        private static List<Recipe> recipes = new List<Recipe>
        {
            new Recipe{ Id=Guid.Parse("00000000-0000-0000-0000-000000000001"), Title="Gemarineerde brochetten", Description="Zo maak je deze klaar!", UserId=Guid.Parse("00000000-0000-0000-0000-000000000001") },
            new Recipe{ Id=Guid.Parse("00000000-0000-0000-0000-000000000002"), Title="Spaghetti bolognaise", Description="De lekkerste spaghetti ooit.", UserId=Guid.Parse("00000000-0000-0000-0000-000000000001") },
            new Recipe{ Id=Guid.Parse("00000000-0000-0000-0000-000000000003"), Title="Testrecept", Description="Test, test en nog eens test.", UserId=Guid.Parse("00000000-0000-0000-0000-000000000002") }
        };


        public async Task<Recipe> GetRecipe(Guid id)
        {
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
            return await Task.FromResult(recipe);
        }

        public Task<Recipe> GetAllRecipes()
        {
            throw new NotImplementedException();

            //TODO: Write this method once API connection is established, GetAll() function is needed
        }

        public async Task<Recipe> AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
            return await Task.FromResult(recipe);
        }

        public async Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            var oldRecipe = recipes.FirstOrDefault(r => r.Id == recipe.Id);
            recipes.Remove(oldRecipe);

            recipes.Add(recipe);
            return await Task.FromResult(recipe);
        }

        public async Task<Recipe> DeleteRecipe(Guid id)
        {
            var oldRecipe = recipes.FirstOrDefault(r => r.Id == id);
            recipes.Remove(oldRecipe);
            return await Task.FromResult(oldRecipe);
        }
    }
}