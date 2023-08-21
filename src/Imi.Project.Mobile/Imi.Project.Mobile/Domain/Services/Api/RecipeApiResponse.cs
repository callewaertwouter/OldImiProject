using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class RecipeApiResponse
    {
        public List<TheMealDbRecipe> Meals { get; set; }
    }

    public class TheMealDbRecipe
    {
        public string IdMeal { get; set; }
        public string StrMeal { get; set; }
        public string StrCategory { get; set; }
        public string StrInstructions { get; set; }
    }
}
