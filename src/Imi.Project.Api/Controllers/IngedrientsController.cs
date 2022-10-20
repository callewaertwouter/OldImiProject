using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngedrientsController : ControllerBase
    {
        /* Since UnitOfMeasure was created for the sole purpose of giving an amount to each ingedrient (i.e. liter milk), 
         * IngedrientsController will also contain everything related to UnitOfMeasure.
           UnitOfMeasure will therefore not have its own controller.
        */
        protected readonly IIngedrientRepository _ingedrientRepository;
        protected readonly IIngedrientService _ingedrientService;
        protected readonly IUnitOfMeasureRepository _unitOfMeasureRepository;

        public IngedrientsController(IIngedrientRepository ingedrientRepository,
                                     IIngedrientService ingedrientService,
                                     IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _ingedrientRepository = ingedrientRepository;
            _ingedrientService = ingedrientService;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }
    }
}