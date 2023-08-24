using Imi.Project.Api.Core.DTOs.UnitOfMeasure;

namespace Imi.Project.Api.Core.DTOs.Ingedrient
{
    public class IngedrientResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string MeasureUnit { get; set; }
    }
}