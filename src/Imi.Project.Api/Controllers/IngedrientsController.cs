using Imi.Project.Api.Core.DTOs.Ingedrient;
using Imi.Project.Api.Core.DTOs.UnitOfMeasure;
using Imi.Project.Api.Core.Entities;
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

        public IngedrientsController(IIngedrientRepository ingedrientRepository)
        {
            _ingedrientRepository = ingedrientRepository;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ingedrients = await _ingedrientRepository.ListAllAsync();
            var ingedrientsDto = ingedrients.Select(i => new IngedrientResponseDto
            {
                Id = i.Id,
                Name = i.Name,
                MeasureUnit = new UnitOfMeasureResponseDto
                {
                    Id = i.UnitOfMeasure.Id,
                    MeasureUnit = i.UnitOfMeasure.MeasureUnit
                }
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
                Name = ingedrient.Name,
                MeasureUnit = new UnitOfMeasureResponseDto
                {
                    Id = ingedrient.UnitOfMeasure.Id,
                    MeasureUnit = ingedrient.UnitOfMeasure.MeasureUnit
                }
            };

            return Ok(ingedrientDto);
        }

        [HttpPost]
        public async Task<IActionResult> Add(IngedrientRequestDto ingedrientDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var ingedrientEntity = new Ingedrient
            {
                Name = ingedrientDto.Name
            };

            await _ingedrientRepository.AddAsync(ingedrientEntity);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(IngedrientRequestDto ingedrientDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var ingedrientEntity = await _ingedrientRepository.GetByIdAsync(ingedrientDto.Id);

            if (ingedrientEntity == null)
            {
                return NotFound($"No ingedrient with an id of {ingedrientDto.Id}");
            }

            ingedrientEntity.Name = ingedrientDto.Name;

            await _ingedrientRepository.UpdateAsync(ingedrientEntity);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ingedrientEntity = await _ingedrientRepository.GetByIdAsync(id);

            if (ingedrientEntity == null)
            {
                return NotFound($"No ingedrient with an id of {id}");
            }

            await _ingedrientRepository.DeleteAsync(ingedrientEntity);

            return Ok();
        }
    }
}