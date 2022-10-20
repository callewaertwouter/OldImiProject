using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Services.Models.RecipeService
{
    public class ViewRecipesResult : ResultBase
    {
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}