using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateRecipesWithStringUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasApprovedTermsAndConditions = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitsOfMeasure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MeasureUnit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsOfMeasure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ingedrients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitOfMeasureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingedrients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingedrients_UnitsOfMeasure_UnitOfMeasureId",
                        column: x => x.UnitOfMeasureId,
                        principalTable: "UnitsOfMeasure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngedrientRecipe",
                columns: table => new
                {
                    IngedrientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngedrientRecipe", x => new { x.IngedrientsId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_IngedrientRecipe_Ingedrients_IngedrientsId",
                        column: x => x.IngedrientsId,
                        principalTable: "Ingedrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngedrientRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "864f4729-15b5-4720-adc9-aeb8466be86d", "admin@admin.com", true, true, false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEPl5d9Rf7Rk3LLohpvOsKoOj8mtpZ1zclJHcIkW+Yc6HR6NtJBEuKv0L22uWIwKAIg==", null, false, "4323ab41-a1f8-4697-9b70-42106dcdf158", false, "Admin" },
                    { "10", 0, new DateTime(2006, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "cb8cf5ad-504d-4a5c-95ea-912904a3cd0e", "toiletbril@gmail.com", true, true, false, null, "TOILETBRIL@GMAIL.COM", "TOITOITOILET", null, null, null, false, "c21f4a74-25e2-4c0b-bc1b-1c3c42383fd6", false, "Toitoitoilet" },
                    { "11", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2b521f3e-5f68-443b-aec6-eb06d954e0a9", "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", null, "AQAAAAEAACcQAAAAEMyE2QsIW9+z1aafdTfXe/3pQn+VXLAw+CfFvU4c5ADgw8UTfthhEqV2FeU7qEGo2g==", null, false, "e83fd804-4613-49c2-86fe-a6533bdd8990", false, "ImiUser" },
                    { "12", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b4dc635e-9342-4467-a0f0-ea929d94ae14", "refuser@imi.be", true, false, false, null, "REFUSER@IMI.BE", "IMIREFUSER", null, "AQAAAAEAACcQAAAAEEXrLcfHYThbCdbBBLN7t+sT9MZmNR7fcwE3jJxFtoWmN6JD30WEmEhbm+oBPkotow==", null, false, "310401d4-efbe-4312-a937-7b4904bddde6", false, "ImiRefuser" },
                    { "13", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e3178032-4463-4b52-ab59-223139ea5bcd", "admin@imi.be", true, false, false, null, "ADMIN@IMI.BE", "IMIADMIN", null, "AQAAAAEAACcQAAAAEA4fo4I/d+Lu/if9xOvrTXpYIZ+53VsCv60WI+UpVNx08Z7iegKzkoo6sS+weWcDew==", null, false, "71124c42-3ca5-47a4-a928-cf0e697e9a94", false, "ImiAdmin" },
                    { "2", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9e626f4d-2e3f-46ec-b7eb-b1b1ad5ea58f", "woutercallewaert@gmail.com", true, true, false, null, "WOUTERCALLEWAERT@GMAIL.COM", "YUSIFER", null, "AQAAAAEAACcQAAAAEK4+Gn7OStWv0nKjirGocAuaRsuRj/7u/56ZR6hm6axfTfVEs9Eiu/wdZUCOGnIXcQ==", null, false, "08e408ea-e41a-4865-942c-a77d82edae73", false, "Yusifer" },
                    { "3", 0, new DateTime(1980, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "111baeb7-8fca-45b4-8e77-31f5bb2cae20", "jjameson@hotmail.com", true, true, false, null, "JJAMESON@HOTMAIL.COM", "JJJ", null, "AQAAAAEAACcQAAAAECJ3+tqYXke2Fb0uuQREW0F1HJBCckKejHOUyR+ulU5WD61/2VKam1XTmZHXpZSeJQ==", null, false, "7b5f5b1a-1ba6-42c1-9a87-d1a78cbc8ec7", false, "JJJ" },
                    { "4", 0, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "96b8aab7-e8c7-46a3-97b2-76c509396b98", "tigbiddies@xxx.com", true, false, false, null, "TIGBIDDIES@XXX.COM", "BIGPP", null, "AQAAAAEAACcQAAAAEN1n2Kzj8RQMlU7wtZSjZQUxCli1WNnb1hkcNiFT0BG7Z+LWW7GnzdM73zKYyNKzQQ==", null, false, "07cc76a7-8959-462b-ab81-2ccaaf43fa46", false, "BigPP" },
                    { "5", 0, new DateTime(1995, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "69430c6c-2923-43ed-9351-c531d9b55f28", "allthebutz@hotmail.com", true, true, false, null, "ALLTHEBUTZ@HOTMAIL.COM", "ALLTHEB", null, "AQAAAAEAACcQAAAAEPvXo5ZHci+o0ew3NZf4lhQ2M5StyVKqPHlUR6z5qJAXkcfoV2rSMK0N1zpWxLBG1g==", null, false, "d61bbed7-c206-42b7-bb1c-fa53cfdeb50b", false, "AlltheB" },
                    { "6", 0, new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "799812fe-c4d9-4be1-986d-5f6f0bf40d9a", "ikloopindiestrond@gagmaker.net", true, true, false, null, "IKLOOPINDIESTROND@GAGMAKER.NET", "TAALJOKER", null, "AQAAAAEAACcQAAAAEEoEEUQ8kFW/IzK2s/2kbwrj2yN9/kXv99OE/0q2ExMOZUX3lL8OGExv80HEcoGUOA==", null, false, "5c59b8eb-ec98-4aa3-8080-5faf9572a811", false, "Taaljoker" },
                    { "7", 0, new DateTime(1999, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "fab355ca-e8df-4578-b3c5-6734f313f39d", "olklo@hotmail.com", true, true, false, null, "OLKLO@HOTMAIL.COM", "PALINGDROOL", null, "AQAAAAEAACcQAAAAEM0eNAUyUctvcgzrNZ69JkO0Y2S5SyGVKi0AQKVz48KlmcQfpb6dboCWPbjftmSIjw==", null, false, "afdcd317-7c90-46cc-80fa-b198d263688c", false, "Palingdrool" },
                    { "8", 0, new DateTime(1991, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "95910d69-bf86-4f46-b2c1-4a1d02255500", "wsmets1991@gmail.com", true, true, false, null, "WSMETS1991@GMAIL.COM", "WSMETS", null, "AQAAAAEAACcQAAAAEKk24Y2DAIBft7qhimnhd6TEDZlthHwQseli0Pkz0jhEcEu0guWMhl6DjPrEQ2wSsQ==", null, false, "bc793d50-25a5-4da4-a9fb-e8e718470563", false, "WSmets" },
                    { "9", 0, new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "a46c355c-cdbc-4c06-a67e-c3bfa859f7f1", "maarten.raviola@hotmail.com", true, true, false, null, "MAARTEN.RAVIOLA@HOTMAIL.COM", "MAVOLIA", null, "AQAAAAEAACcQAAAAENb+anoghDPfvdwN5tRYpOQeh3QwG2Fyqw1DTKv2tgkLQlrAEJXwozETiCMXSBgvHQ==", null, false, "6e97f631-d093-457e-b492-98d83e5e5d6c", false, "Mavolia" }
                });

            migrationBuilder.InsertData(
                table: "UnitsOfMeasure",
                columns: new[] { "Id", "MeasureUnit" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "gram" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "liter" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "blik(ken)" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "tak(ken)" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "blaadje(s)" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "deciliter" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "centiliter" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "bakje(s)" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "vrij naar keuze" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "geen" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), " " }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "admin", "1" },
                    { 2, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "2" },
                    { 3, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "3" },
                    { 4, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "refuser", "4" },
                    { 5, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "5" },
                    { 6, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "6" },
                    { 7, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "7" },
                    { 8, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "8" },
                    { 9, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "9" },
                    { 10, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "10" },
                    { 11, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "11" },
                    { 12, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "refuser", "12" },
                    { 13, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "admin", "13" }
                });

            migrationBuilder.InsertData(
                table: "Ingedrients",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5387), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5393), "Melk", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5399), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5400), "Laurier", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5404), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5405), "Gehakt", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5409), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5410), "Tomatenpuree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5415), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5415), "Boter", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5419), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5420), "Paprika", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5424), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5425), "Wortel", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5429), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5430), "Ajuin", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5434), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5435), "Kippenbouillon", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5439), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5440), "Olijfolie", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5444), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5445), "Champignons", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5450), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5451), "Gemalen kaas", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5456), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5457), "Spaghetti", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5465), new DateTime(2022, 11, 24, 13, 22, 23, 339, DateTimeKind.Utc).AddTicks(5466), "Courgette", new Guid("00000000-0000-0000-0000-000000000011") }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "Description", "LastEditedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5521), "Dit recept test de werking van dit recept.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5592), "Testrecept", "1" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5603), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5607), "Witte saus", "4" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5614), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5618), "Gemarineerde brochetten", "2" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5624), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5628), "Champignonsoep", "8" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5634), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5638), "Gehaktbrood met bonen en patatten", "3" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5644), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5648), "Hamburger met wortel en patatten", "9" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5655), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5658), "Viskroketjes met gebakken aardappelen", "5" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5665), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5669), "Grillworst met puree", "7" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5675), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5678), "Spaghetti bolognaise", "2" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5685), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 11, 24, 14, 22, 23, 339, DateTimeKind.Local).AddTicks(5688), "Ongelooflijk goed gerecht", "10" }
                });

            migrationBuilder.InsertData(
                table: "IngedrientRecipe",
                columns: new[] { "IngedrientsId", "RecipesId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000009") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IngedrientRecipe_RecipesId",
                table: "IngedrientRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingedrients_UnitOfMeasureId",
                table: "Ingedrients",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "IngedrientRecipe");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ingedrients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasure");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
