using Imi.Project.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Data.Seeding
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Email = "admin@admin.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Email = "woutercallewaert@gmail.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Email = "jjameson@hotmail.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Email = "tigbiddies@xxx.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Email = "allthebutz@hotmail.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Email = "ikloopindiestrond@gagmaker.net",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Email = "olklo@gmail.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Email = "wsmets1991@hotmail.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Email = "maarten.raviola@gmail.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                },

                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Email = "toiletbril@lolbroek.com",
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now,
                }
                );
        }
    }
}
