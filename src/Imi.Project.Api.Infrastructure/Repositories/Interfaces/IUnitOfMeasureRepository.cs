using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.Interfaces
{
    public interface IUnitOfMeasureRepository
    {
        // As the entity UnitOfMeasure is read-only for now, it will not inherit BaseEntity and will have functions on its own.
        // I'm currently on the fence on whether or not to add full CRUD for this too. For now I'll keep it read-only.

        IQueryable<UnitOfMeasure> GetAll();

        Task<IEnumerable<UnitOfMeasure>> ListAllAsync();

        Task<UnitOfMeasure> GetByIdAsync(Guid id);
    }
}
