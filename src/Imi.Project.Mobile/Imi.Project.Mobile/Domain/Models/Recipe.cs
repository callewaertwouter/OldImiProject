using System;

namespace Imi.Project.Mobile.Domain.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public User CreatedByUser { get; set; }

        //TODO: Add list of ingedrients which is borrowed from the database (API connection required)
    }
}