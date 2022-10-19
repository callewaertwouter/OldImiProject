using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Entities
{

    // Linking table for the many-to-many relationship between Recipe and Ingedrient
    /* Generating one with EF resulted in an error: "The property 'RecipeId, IngedrientId' cannot be added 
     * to the type 'RecipeIngedrients (Dictionary<string, object>)' because no property type was specified and there is no corresponding CLR property or field. 
     * To add a shadow state property, the property type must be specified."
     
     Therefore creating the linking table as an entity to bypass this problem. To see the code and error, switch to branch "Linking-table".
     */
    public class RecipeIngedrient
    {
        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public Guid IngedrientId { get; set; }
        public Ingedrient Ingedrient { get; set; }
    }
}
