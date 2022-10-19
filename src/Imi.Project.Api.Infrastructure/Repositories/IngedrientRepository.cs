using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Infrastructure.Data;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class IngedrientRepository : BaseRepository<Ingedrient>, IIngedrientRepository
    {
        public IngedrientRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
