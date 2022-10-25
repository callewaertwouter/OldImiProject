using Imi.Project.Api.Core.Entities;

namespace Imi.Project.Blazor.Services
{
    public class BlazorRecipeService : ICRUDService<Recipe>
    {
        static List<Recipe> recipes = new List<Recipe>();

        public Task<Recipe> Get(Guid id)
        {
            return Task.FromResult(
                recipes.SingleOrDefault(x => x.Id == id)
                );
        }

        public Task<IQueryable<Recipe>> GetAll()
        {
            return Task.FromResult(
                recipes.Select(x => new Recipe()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Ingedrients = x.Ingedrients,
                    User = x.User
                }).AsQueryable()
                );
        }

        public Task Create(Recipe item)
        {
            item.Id = Guid.NewGuid();
            recipes.Add(item);
            return Task.CompletedTask;
        }

        public Task Update(Recipe item)
        {
            var recipe = recipes.SingleOrDefault(x => x.Id == item.Id);

            if (recipe == null) throw new ArgumentException("Recipe not found...");

            recipe.Title = item.Title;
            recipe.Description = item.Description;
            recipe.Ingedrients = item.Ingedrients;
            recipe.User = item.User;

            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var recipe = recipes.SingleOrDefault(x => x.Id == id);
            
            if (recipe == null) throw new ArgumentException("Recipe not found...");

            recipes.Remove(recipe);
            return Task.CompletedTask;
        }
    }
}