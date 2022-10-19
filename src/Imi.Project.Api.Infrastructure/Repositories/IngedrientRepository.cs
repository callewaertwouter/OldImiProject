using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class IngedrientRepository : BaseRepository<Ingedrient>, IIngedrientRepository
    {
        public IngedrientRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
