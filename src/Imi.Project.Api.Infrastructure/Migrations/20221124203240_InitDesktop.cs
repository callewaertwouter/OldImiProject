using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitDesktop : Migration
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
                    { "1", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4b03b57-b632-4601-9023-1c05c0a853bd", "admin@admin.com", true, true, false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEGoGladwq8BgcKtqArmrRH20MaYEILMIpVu8DbMc7op0n2quPEVMu0mVC2qoKoK92Q==", null, false, "2b70592c-eb7e-479c-9c62-64bd30f989f7", false, "Admin" },
                    { "10", 0, new DateTime(2006, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "f437d35b-aa9b-4522-8cdd-9ab73e2b6468", "toiletbril@gmail.com", true, true, false, null, "TOILETBRIL@GMAIL.COM", "TOITOITOILET", null, null, null, false, "e96fb988-6eaa-4497-9681-e141df14f225", false, "Toitoitoilet" },
                    { "11", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f8d4d457-b081-43a6-a1aa-91195dc569ab", "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", null, "AQAAAAEAACcQAAAAEH7ki3K7ied96YjszVfbXZTgBOEd5qLrev3pd4lkBS15jZtCGaC8fPIqBymLG5A0tw==", null, false, "2c7ae452-c346-422d-a46d-8b562147bd60", false, "ImiUser" },
                    { "12", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "32f1aa73-ef98-475c-8c52-fa123efd67f0", "refuser@imi.be", true, false, false, null, "REFUSER@IMI.BE", "IMIREFUSER", null, "AQAAAAEAACcQAAAAENfbg91gKnuFV5TmDdNJQ9mmrwDVXZnFlcpQ6AIGe23S/76Toov8dZIp2YMPssNv7w==", null, false, "2002a2d1-61e9-4bb0-ae69-43388e899e67", false, "ImiRefuser" },
                    { "13", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d9efda31-761f-43c4-83bd-9fdac48d9176", "admin@imi.be", true, false, false, null, "ADMIN@IMI.BE", "IMIADMIN", null, "AQAAAAEAACcQAAAAENeZ38K8EZU75T0GBqguxEjz8s6f947TcEJxKsNhfcAvxG+KgFKxV3B7Xpc5ow152A==", null, false, "a0b0f4d1-c260-4f1a-8887-385e9fbcb0e5", false, "ImiAdmin" },
                    { "2", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "c72709bf-fb0e-46fe-b1a0-24d9f1e1c53d", "woutercallewaert@gmail.com", true, true, false, null, "WOUTERCALLEWAERT@GMAIL.COM", "YUSIFER", null, "AQAAAAEAACcQAAAAEOwRBPb3eItxy+mCPxDS+e6CGTEJYoSO6Z61QMxd2rd0dLlHfwnmLbwBg+tYBLLI1w==", null, false, "1905b0cc-9050-471c-bb11-482b89f256da", false, "Yusifer" },
                    { "3", 0, new DateTime(1980, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "a881a108-6b2b-4c6a-9727-f8802a2d6f1c", "jjameson@hotmail.com", true, true, false, null, "JJAMESON@HOTMAIL.COM", "JJJ", null, "AQAAAAEAACcQAAAAEKOpCyQqZga7Tv+NPNGOHQCc0rK5C31BBAVhAln3X5hju4mamBB3O1BrfEqjbACVWA==", null, false, "29ba1fd6-fcad-4def-837a-37a6c57c7fee", false, "JJJ" },
                    { "4", 0, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0bd12edd-dbbe-404d-81b4-324effba04ce", "tigbiddies@xxx.com", true, false, false, null, "TIGBIDDIES@XXX.COM", "BIGPP", null, "AQAAAAEAACcQAAAAEFrVksNAIXh8i8WiVc3G8sFercnOjpv5f9iLTYWSlihImz0TaqKTkio/+N5P5gjHyA==", null, false, "53bfc517-e729-4aec-8226-95b55759c00a", false, "BigPP" },
                    { "5", 0, new DateTime(1995, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "2f4d3eb5-7695-4431-ba4a-c3cc4c462dfb", "allthebutz@hotmail.com", true, true, false, null, "ALLTHEBUTZ@HOTMAIL.COM", "ALLTHEB", null, "AQAAAAEAACcQAAAAEABVkwRZ/wR4vQAZHXV/6ZGwS72WCMMnx7tvIS3SimDJLTpqx7ejjbf+nhtWPS+/+A==", null, false, "80e68475-d8bc-423e-9d27-ea067ab32ee1", false, "AlltheB" },
                    { "6", 0, new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "db71c177-9161-4491-b94a-49f06ebb3295", "ikloopindiestrond@gagmaker.net", true, true, false, null, "IKLOOPINDIESTROND@GAGMAKER.NET", "TAALJOKER", null, "AQAAAAEAACcQAAAAEDt05icnoFQo+az7IRzJ0jv32nkjnQfK7FxJy2HYTn2hYcqG57HFH0oPGexbgawAvg==", null, false, "13af9ea9-a3f7-461b-ab13-86964a41c4a5", false, "Taaljoker" },
                    { "7", 0, new DateTime(1999, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "b5e9edaa-ea76-4040-91ae-576e876ae104", "olklo@hotmail.com", true, true, false, null, "OLKLO@HOTMAIL.COM", "PALINGDROOL", null, "AQAAAAEAACcQAAAAEKIEp7ldLXoZ4jweLAFvykWKf0k0S4yREZ6D2HjGoxv372YpRcm3AFZiDrYWWO0ABg==", null, false, "bbc38772-139b-4967-999b-f066620f49bf", false, "Palingdrool" },
                    { "8", 0, new DateTime(1991, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "1cb400d4-ecfa-403a-8f71-67878f6b8437", "wsmets1991@gmail.com", true, true, false, null, "WSMETS1991@GMAIL.COM", "WSMETS", null, "AQAAAAEAACcQAAAAELfU6u+fOJ2NvwmM1urnEeH2DflwTVSoXu6xrpbIiKKzUgONEQKEb14trWlIdLs0DQ==", null, false, "9428d0ef-91bd-40ec-a319-71521696cd2a", false, "WSmets" },
                    { "9", 0, new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "8698bf88-bd05-4681-88a6-852e1b5ed756", "maarten.raviola@hotmail.com", true, true, false, null, "MAARTEN.RAVIOLA@HOTMAIL.COM", "MAVOLIA", null, "AQAAAAEAACcQAAAAEC6MyX6kQaY78sliUJdPhWNebcBy2DC3lrvDJFbJH30c8qvjJANCBxB2dBksfl81IA==", null, false, "944a816b-1470-4be9-bcc7-04a3b7907d75", false, "Mavolia" }
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
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1914), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1915), "Melk", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1917), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1917), "Laurier", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1919), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1919), "Gehakt", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1921), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1921), "Tomatenpuree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1923), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1923), "Boter", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1925), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1925), "Paprika", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1927), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1927), "Wortel", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1929), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1929), "Ajuin", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1931), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1931), "Kippenbouillon", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1933), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1933), "Olijfolie", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1935), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1935), "Champignons", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1938), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1939), "Gemalen kaas", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1940), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1941), "Spaghetti", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1965), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1965), "Courgette", new Guid("00000000-0000-0000-0000-000000000011") }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "Description", "LastEditedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(1984), "Dit recept test de werking van dit recept.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2023), "Testrecept", "1" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2026), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2027), "Witte saus", "4" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2031), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2032), "Gemarineerde brochetten", "2" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2035), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2036), "Champignonsoep", "8" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2039), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2040), "Gehaktbrood met bonen en patatten", "3" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2043), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2044), "Hamburger met wortel en patatten", "9" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2047), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2048), "Viskroketjes met gebakken aardappelen", "5" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2051), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2052), "Grillworst met puree", "7" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2055), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2056), "Spaghetti bolognaise", "2" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2059), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2060), "Ongelooflijk goed gerecht", "10" }
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
