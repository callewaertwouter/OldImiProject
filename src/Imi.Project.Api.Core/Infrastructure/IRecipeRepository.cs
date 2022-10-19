using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Infrastructure
{
    public interface IRecipeRepository : IBaseRepository<Recipe>
    {
        Task<IEnumerable<Recipe>> GetByUserIdAsync(Guid id);

        Task<IEnumerable<Recipe>> SearchAsync(string search);
    }
}