using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            IPasswordHasher<User> passwordHasher = new PasswordHasher<User>();

            // IMI User
            var imiUser = new User
            {
                Id = "11",
                UserName = "ImiUser",
                NormalizedUserName = "IMIUSER",
                Email = "user@imi.be",
                NormalizedEmail = "USER@IMI.BE",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                HasApprovedTermsAndConditions = true
            };

            imiUser.PasswordHash = passwordHasher.HashPassword(imiUser, "Test123?");
            modelBuilder.Entity<User>().HasData(imiUser);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 11,
                    UserId = "11",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // IMI Refuser
            var imiRefuser = new User
            {
                Id = "12",
                UserName = "ImiRefuser",
                NormalizedUserName = "IMIREFUSER",
                Email = "refuser@imi.be",
                NormalizedEmail = "REFUSER@IMI.BE",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                HasApprovedTermsAndConditions = false
            };

            imiRefuser.PasswordHash = passwordHasher.HashPassword(imiRefuser, "Test123?");
            modelBuilder.Entity<User>().HasData(imiRefuser);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 12,
                    UserId = "12",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "refuser"
                });

            // IMI Admin
            var imiAdmin = new User
            {
                Id = "13",
                UserName = "ImiAdmin",
                NormalizedUserName = "IMIADMIN",
                Email = "admin@imi.be",
                NormalizedEmail = "ADMIN@IMI.BE",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true
            };

            imiAdmin.PasswordHash = passwordHasher.HashPassword(imiAdmin, "Test123?");
            modelBuilder.Entity<User>().HasData(imiAdmin);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 13,
                    UserId = "13",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "admin"
                });


            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserName = "Admin",
                    Email = "admin@admin.com",
                    Password = "Test123?",
                    Birthday = new DateTime(1990, 1, 1),
                    HasApprovedTermsAndConditions = true
                },

                new User
                {
                    UserName = "Yusifer",
                    Email = "woutercallewaert@gmail.com"
                },

                new User
                {
                    Email = "jjameson@hotmail.com"
                },

                new User
                {
                    Email = "tigbiddies@xxx.com"
                },

                new User
                {
                    Email = "allthebutz@hotmail.com"
                },

                new User
                {
                    Email = "ikloopindiestrond@gagmaker.net"
                },

                new User
                {
                    Email = "olklo@gmail.com"
                },

                new User
                {
                    Email = "wsmets1991@hotmail.com"
                },

                new User
                {
                    Email = "maarten.raviola@gmail.com"
                },

                new User
                {
                    Email = "toiletbril@lolbroek.com"
                }

                );
        }
    }
}
