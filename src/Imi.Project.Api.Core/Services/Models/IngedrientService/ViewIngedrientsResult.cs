using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Services.Models.IngedrientService
{
    public class ViewIngedrientsResult : ResultBase
    {
        public IEnumerable<Ingedrient> Ingedrients { get; set; }

        // Everything related to UnitOfMeasure exists only to give ingedrients an amount (i.e. liter milk)
        public IEnumerable<UnitOfMeasure> UnitsOfMeasure { get; set; }
    }
}