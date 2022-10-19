using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class UnitOfMeasureRepository : IUnitOfMeasureRepository
    {
        protected readonly AppDbContext _dbContext;

        public UnitOfMeasureRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IQueryable<UnitOfMeasure> GetAll()
        {
            return _dbContext.Set<UnitOfMeasure>().AsQueryable();
        }

        public virtual async Task<IEnumerable<UnitOfMeasure>> ListAllAsync()
        {
            return await _dbContext.Set<UnitOfMeasure>().ToListAsync();
        }

        public virtual async Task<UnitOfMeasure> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<UnitOfMeasure>().SingleOrDefaultAsync(um => um.Id.Equals(id));
        }
    }
}