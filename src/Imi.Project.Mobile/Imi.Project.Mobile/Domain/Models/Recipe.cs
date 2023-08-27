using System;
using System.Collections.Generic;

namespace Imi.Project.Mobile.Domain.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Guid UserId { get; set; }
        public User CreatedByUser { get; set; }

		public List<Ingredient> Ingredients { get; set; }
	}
}