using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RecipeSeeder
    {
        //TODO Add list of ingedrients to each recipe and which user created it
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Title = "Testrecept",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Title = "Witte saus",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Title = "Gemarineerde brochetten",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Title = "Champignonsoep",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Title = "Gehaktbrood met bonen en patatten",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Title = "Hamburger met wortel en patatten",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Title = "Viskroketjes met gebakken aardappelen",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Title = "Grillworst met puree",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Title = "Spaghetti bolognaise",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Title = "Ongelooflijk goed gerecht",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                }
                );
        }
    }
}
