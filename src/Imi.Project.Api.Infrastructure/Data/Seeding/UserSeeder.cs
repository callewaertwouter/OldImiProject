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

            // User 1: Admin Role
            var user1 = new User
            {
                Id = "1",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1986, 7, 6),
                HasApprovedTermsAndConditions = true
            };

            user1.PasswordHash = passwordHasher.HashPassword(user1, "Test123?");
            modelBuilder.Entity<User>().HasData(user1);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 1,
                    UserId = "1",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "admin"
                });

            // User 2: Random user
            var user2 = new User
            {
                Id = "2",
                UserName = "Yusifer",
                NormalizedUserName = "YUSIFER",
                Email = "woutercallewaert@gmail.com",
                NormalizedEmail = "WOUTERCALLEWAERT@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1986, 7, 6),
                HasApprovedTermsAndConditions = true
            };

            user2.PasswordHash = passwordHasher.HashPassword(user2, "Test123?");
            modelBuilder.Entity<User>().HasData(user2);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 2,
                    UserId = "2",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // User 3: random user
            var user3 = new User
            {
                Id = "3",
                UserName = "JJJ",
                NormalizedUserName = "JJJ",
                Email = "jjameson@hotmail.com",
                NormalizedEmail = "JJAMESON@HOTMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1980, 5, 28),
                HasApprovedTermsAndConditions = true
            };

            user3.PasswordHash = passwordHasher.HashPassword(user3, "Test123?");
            modelBuilder.Entity<User>().HasData(user3);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 3,
                    UserId = "3",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // User 4: random user

            var user4 = new User
            {
                Id = "4",
                UserName = "BigPP",
                NormalizedUserName = "BIGPP",
                Email = "tigbiddies@xxx.com",
                NormalizedEmail = "TIGBIDDIES@XXX.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1970, 1, 1),
                HasApprovedTermsAndConditions = false
            };

            user4.PasswordHash = passwordHasher.HashPassword(user4, "Test123?");
            modelBuilder.Entity<User>().HasData(user4);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 4,
                    UserId = "4",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "refuser"
                });

            // User 5: random user

            var user5 = new User
            {
                Id = "5",
                UserName = "AlltheB",
                NormalizedUserName = "ALLTHEB",
                Email = "allthebutz@hotmail.com",
                NormalizedEmail = "ALLTHEBUTZ@HOTMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1995, 9, 12),
                HasApprovedTermsAndConditions = true
            };

            user5.PasswordHash = passwordHasher.HashPassword(user5, "Test123?");
            modelBuilder.Entity<User>().HasData(user5);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 5,
                    UserId = "5",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // User 6: random user

            var user6 = new User
            {
                Id = "6",
                UserName = "Taaljoker",
                NormalizedUserName = "TAALJOKER",
                Email = "ikloopindiestrond@gagmaker.net",
                NormalizedEmail = "IKLOOPINDIESTROND@GAGMAKER.NET",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(2010, 11, 11),
                HasApprovedTermsAndConditions = true
            };

            user6.PasswordHash = passwordHasher.HashPassword(user6, "Test123?");
            modelBuilder.Entity<User>().HasData(user6);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 6,
                    UserId = "6",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // User 7: random user

            var user7 = new User
            {
                Id = "7",
                UserName = "Palingdrool",
                NormalizedUserName = "PALINGDROOL",
                Email = "olklo@hotmail.com",
                NormalizedEmail = "OLKLO@HOTMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1999, 9, 19),
                HasApprovedTermsAndConditions = true
            };

            user7.PasswordHash = passwordHasher.HashPassword(user7, "Test123?");
            modelBuilder.Entity<User>().HasData(user7);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 7,
                    UserId = "7",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // User 8: random user

            var user8 = new User
            {
                Id = "8",
                UserName = "WSmets",
                NormalizedUserName = "WSMETS",
                Email = "wsmets1991@gmail.com",
                NormalizedEmail = "WSMETS1991@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1991, 2, 8),
                HasApprovedTermsAndConditions = true
            };

            user8.PasswordHash = passwordHasher.HashPassword(user8, "Test123?");
            modelBuilder.Entity<User>().HasData(user8);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 8,
                    UserId = "8",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // User 9: random user

            var user9 = new User
            {
                Id = "9",
                UserName = "Mavolia",
                NormalizedUserName = "MAVOLIA",
                Email = "maarten.raviola@hotmail.com",
                NormalizedEmail = "MAARTEN.RAVIOLA@HOTMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(1982, 4, 15),
                HasApprovedTermsAndConditions = true
            };

            user9.PasswordHash = passwordHasher.HashPassword(user9, "Test123?");
            modelBuilder.Entity<User>().HasData(user9);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 9,
                    UserId = "9",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });

            // User 10: random user

            var user10 = new User
            {
                Id = "10",
                UserName = "Toitoitoilet",
                NormalizedUserName = "TOITOITOILET",
                Email = "toiletbril@gmail.com",
                NormalizedEmail = "TOILETBRIL@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                Birthday = new DateTime(2006, 3, 29),
                HasApprovedTermsAndConditions = true
            };

            user3.PasswordHash = passwordHasher.HashPassword(user10, "Test123?");
            modelBuilder.Entity<User>().HasData(user10);

            modelBuilder.Entity<IdentityUserClaim<string>>()
                .HasData(new IdentityUserClaim<string>
                {
                    Id = 10,
                    UserId = "10",
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = "user"
                });
        }
    }
}
