using Imi.Project.Api.Core.DTOs.Ingedrient;
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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ingedrients = await _ingedrientRepository.ListAllAsync();
            var ingedrientsDto = ingedrients.Select(i => new IngedrientResponseDto
            {
                Id = i.Id,
                Name = i.Name
            });

            return Ok(ingedrientsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var ingedrient = await _ingedrientRepository.GetByIdAsync(id);

            if (ingedrient == null)
            {
                return NotFound($"No ingedrient found with an id of {id}.");
            }

            var ingedrientDto = new IngedrientResponseDto
            {
                Id = ingedrient.Id,
                Name = ingedrient.Name
            };

            return Ok(ingedrientDto);
        }
    }
}