using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.DTOs.Ingedrient
{
    public class IngedrientRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required!")]
        public string Name { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}