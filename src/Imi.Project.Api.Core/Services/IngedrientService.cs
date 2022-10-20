using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure;
using Imi.Project.Api.Core.Services.Interfaces;
using Imi.Project.Api.Core.Services.Models.IngedrientService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class IngedrientService : IIngedrientService
    {
        private readonly IIngedrientRepository _ingedrientRepository;
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;

        public IngedrientService(IIngedrientRepository ingedrientRepository,
                                 IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _ingedrientRepository = ingedrientRepository;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<ViewIngedrientsResult> GetAllIngedrients()
        {
            var result = new ViewIngedrientsResult();
            result.ValidationResults = new List<ValidationResult>();

            result.Ingedrients = await _ingedrientRepository.ListAllAsync();
            result.IsSuccess = true;

            return result;
        }

        public async Task<ViewIngedrientsResult> GetIngedrientById(Guid id)
        {
            var result = new ViewIngedrientsResult();
            var validationResults = new List<ValidationResult>();

            var ingedrient = await _ingedrientRepository.GetByIdAsync(id);

            if (ingedrient == null)
            {
                validationResults.Add(new ValidationResult($"Ingedrient with id {id} is not found."));
                result.IsSuccess = false;
            }
            else
            {
                var ingedrients = new List<Ingedrient>();
                ingedrients.Add(ingedrient);

                result.Ingedrients = ingedrients;
                result.IsSuccess = true;
            }

            result.ValidationResults = validationResults;

            return result;
        }

        public async Task<ViewIngedrientsResult> GetUnitOfMeasureById(Guid id)
        {
            var result = new ViewIngedrientsResult();
            var validationResults = new List<ValidationResult>();

            var unitOfMeasure = await _unitOfMeasureRepository.GetByIdAsync(id);

            if (unitOfMeasure == null)
            {
                validationResults.Add(new ValidationResult($"Unit of measure with id {id} is not found."));
                result.IsSuccess = false;
            }
            else
            {
                var unitsOfMeasure = new List<UnitOfMeasure>();
                unitsOfMeasure.Add(unitOfMeasure);

                result.UnitsOfMeasure = unitsOfMeasure;
                result.IsSuccess = true;
            }

            result.ValidationResults = validationResults;

            return result;
        }
    }
}