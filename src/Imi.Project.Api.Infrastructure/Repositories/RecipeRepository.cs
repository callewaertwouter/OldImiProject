using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class RecipeRepository : BaseRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        // Since there's already a GetAll from BaseRepository, override allows it to change just the code
        public override IQueryable<Recipe> GetAll()
        {
            return _dbContext.Recipes.Include(r => r.ListOfIngedrients);
        }

        public async override Task<IEnumerable<Recipe>> ListAllAsync()
        {
            var recipes = await GetAll().ToListAsync();

            return recipes;
        }

        public async override Task<Recipe> GetByIdAsync(Guid id)
        {
            var recipe = await GetAll().SingleOrDefaultAsync(r => r.Id.Equals(id));

            return recipe;
        }

        // Functions below appear only in this interface, so no override needed
        public async Task<IEnumerable<Recipe>> GetByUserIdAsync(Guid id)
        {
            var recipes = await GetAll().Where(r => r.UserId.Equals(id)).ToListAsync();

            return recipes;
        }

        public async Task<IEnumerable<Recipe>> SearchAsync(string search)
        {
            var recipes = await GetAll()
                                .Where(r => r.Title.Contains(search.Trim().ToUpper()) || r.User.Email.Contains(search.Trim().ToUpper()))
                                .ToListAsync();

            return recipes;
        }
    }
}
