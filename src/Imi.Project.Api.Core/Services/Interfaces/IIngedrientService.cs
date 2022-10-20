using Imi.Project.Api.Core.Services.Models.IngedrientService;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Interfaces
{
    public interface IIngedrientService
    {
        Task<ViewIngedrientsResult> GetAllIngedrients();

        Task<ViewIngedrientsResult> GetIngedrientById(Guid id);

        Task<ViewIngedrientsResult> GetUnitOfMeasureById(Guid id);
    }
}