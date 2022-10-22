using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class IngedrientRepository : BaseRepository<Ingedrient>, IIngedrientRepository
    {
        public IngedrientRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }

        public override IQueryable<Ingedrient> GetAll()
        {
            return _dbContext.Ingedrients.Include(i => i.UnitOfMeasure);
        }

        public async override Task<IEnumerable<Ingedrient>> ListAllAsync()
        {
            var ingedrients = await GetAll().ToListAsync();

            return ingedrients;
        }

        public async override Task<Ingedrient> GetByIdAsync(Guid id)
        {
            var ingedrient = await GetAll().SingleOrDefaultAsync(r => r.Id.Equals(id));

            return ingedrient;
        }
    }
}
