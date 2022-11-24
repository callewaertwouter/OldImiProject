using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class IdentityDbContextMonitoraat : Migration
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
                    { "1", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "84ff3821-952b-4530-95ce-dbb90f17480f", "admin@admin.com", true, true, false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAEJuhE+2uMxQdKdmFI4JWAMyBOmC24CICbLD1PmYzdI4u8yT0COyug6HVEsw5ZsSJAg==", null, false, "73da36cb-0cd3-4ad0-9161-9cb27ca4aec8", false, "Admin" },
                    { "10", 0, new DateTime(2006, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "be2c173a-d975-4eb9-8a91-29cb3fb891d9", "toiletbril@gmail.com", true, true, false, null, "TOILETBRIL@GMAIL.COM", "TOITOITOILET", null, null, null, false, "27e451e1-8cb6-4c9b-a3c3-42f055b14112", false, "Toitoitoilet" },
                    { "11", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "579c221b-de4e-47e6-acad-79c60f4d1956", "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", null, "AQAAAAEAACcQAAAAEJX0/8Csid/mYhB5QMQk7CEOCE0frMMsYNmIG6FJPxCHqwRKAdcklWbOWNdU47LX0g==", null, false, "6ef70d6f-7d35-4914-b7fc-6da6d67e6fcd", false, "ImiUser" },
                    { "12", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2587bf60-8853-45d6-9447-309f0139c7fa", "refuser@imi.be", true, false, false, null, "REFUSER@IMI.BE", "IMIREFUSER", null, "AQAAAAEAACcQAAAAEAgl5laGFgiiDyWvDP6qrZZPJq1kXjxL/JubvsBwNj1EliAms5lgPS+RERHhmTAcOg==", null, false, "7fa84522-810e-418a-8f6c-4d876c06babf", false, "ImiRefuser" },
                    { "13", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "73ef3c0b-1b4b-4572-aa3b-d52978cd8c45", "admin@imi.be", true, false, false, null, "ADMIN@IMI.BE", "IMIADMIN", null, "AQAAAAEAACcQAAAAELrHyZPHlV54lzNY1/oSF9tPLqM6habhTvZ6zkzxmMevITrRiKe8+iWopVCog1TJsA==", null, false, "fd11c83b-3e9e-4e1e-8e62-d60344ebb566", false, "ImiAdmin" },
                    { "2", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "c31bed7c-23f2-42c9-897c-3ddc54de6ede", "woutercallewaert@gmail.com", true, true, false, null, "WOUTERCALLEWAERT@GMAIL.COM", "YUSIFER", null, "AQAAAAEAACcQAAAAEHNaRSUeYq1UV+gBt1MsvswlbaDbE1MCIYTcumuwaD+atXfWDAi1gwvyWssvAsCHKw==", null, false, "cc56cf1d-ecef-43da-b2bb-8ab76249c269", false, "Yusifer" },
                    { "3", 0, new DateTime(1980, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "e31f6ebb-9e76-4134-b2f2-c1aaf2684271", "jjameson@hotmail.com", true, true, false, null, "JJAMESON@HOTMAIL.COM", "JJJ", null, "AQAAAAEAACcQAAAAEDAhFmt5NS/YmYtWzfrS7ADFrqwfV5MQU/SXhqgoc+NIrJduHUwr0/ajNPOKqSHPkw==", null, false, "80155647-c54a-453a-acfa-1499fdba7e79", false, "JJJ" },
                    { "4", 0, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "172cddaa-6ca8-4605-ae0c-01e5802b7d0c", "tigbiddies@xxx.com", true, false, false, null, "TIGBIDDIES@XXX.COM", "BIGPP", null, "AQAAAAEAACcQAAAAEARXvWpPBU2TvPHCI7idA0Kc0muXIpmfV9YhMux2Kc792l6QjzaUyeH2kIY3hOqW8Q==", null, false, "9a56b8ea-cf7c-4fc3-b226-791bf8ebb5c3", false, "BigPP" },
                    { "5", 0, new DateTime(1995, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "74f27c03-ae51-49ba-82db-c44b3f84f097", "allthebutz@hotmail.com", true, true, false, null, "ALLTHEBUTZ@HOTMAIL.COM", "ALLTHEB", null, "AQAAAAEAACcQAAAAEDzUh+LhY4gQpzoGBsnkaJjP9mPFv94/fSeeK4OP8jCB/rI0jv3QpU9A1JwAp7QwKw==", null, false, "155a50db-e4e1-45e0-9410-9d6c5e04d20f", false, "AlltheB" },
                    { "6", 0, new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddc5902e-d815-42e0-b696-30ffb5e4f8ba", "ikloopindiestrond@gagmaker.net", true, true, false, null, "IKLOOPINDIESTROND@GAGMAKER.NET", "TAALJOKER", null, "AQAAAAEAACcQAAAAELGbZdOkvTbbv9t8J1/KDS/Z7HTop3k1WansOtbjAsmUgnVU6FBn25nBexG8xKMi6A==", null, false, "c2432593-1cf0-4b3c-8994-6535a9d884de", false, "Taaljoker" },
                    { "7", 0, new DateTime(1999, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f4923bc-0925-4720-8cc2-e84767c77a58", "olklo@hotmail.com", true, true, false, null, "OLKLO@HOTMAIL.COM", "PALINGDROOL", null, "AQAAAAEAACcQAAAAEBjz0ApBYyAtv2c6LgO6x9lFsdEgBiebKNTiycRhxA81CKLgGcVZ3imGr+l1HdCdig==", null, false, "bfb7be00-f866-4376-9368-6747803e000a", false, "Palingdrool" },
                    { "8", 0, new DateTime(1991, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "0d547642-b7e5-4eed-a443-31504fb06f4e", "wsmets1991@gmail.com", true, true, false, null, "WSMETS1991@GMAIL.COM", "WSMETS", null, "AQAAAAEAACcQAAAAEJLMYPCkwPUyCo3HfLEIGbODjxMZtKTDs6278lYRRvID1Q+Eu1qlOU4kjSFP2zUSRQ==", null, false, "04cb55b8-dcd7-4bac-87df-666f28832915", false, "WSmets" },
                    { "9", 0, new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7314f7f-5bf9-49a1-9eb1-4caee0d6a86f", "maarten.raviola@hotmail.com", true, true, false, null, "MAARTEN.RAVIOLA@HOTMAIL.COM", "MAVOLIA", null, "AQAAAAEAACcQAAAAENccpncvJlN7xc5bJ57oYl6vnfeHDC0OCgqsZn+kYI4EihhxpoRG1i1bIZIw1c+j0A==", null, false, "66708ac9-e5df-4b07-b5bb-31e13450ead5", false, "Mavolia" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "Description", "LastEditedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8581), "Dit recept test de werking van dit recept.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8679), "Testrecept", null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8688), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8691), "Witte saus", null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8697), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8701), "Gemarineerde brochetten", null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8707), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8711), "Champignonsoep", null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8717), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8721), "Gehaktbrood met bonen en patatten", null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8726), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8730), "Hamburger met wortel en patatten", null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8737), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8745), "Viskroketjes met gebakken aardappelen", null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8753), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8758), "Grillworst met puree", null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8767), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8773), "Spaghetti bolognaise", null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8782), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 11, 24, 9, 48, 58, 364, DateTimeKind.Local).AddTicks(8787), "Ongelooflijk goed gerecht", null }
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
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8451), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8455), "Melk", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8461), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8462), "Laurier", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8466), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8467), "Gehakt", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8471), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8471), "Tomatenpuree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8476), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8476), "Boter", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8481), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8481), "Paprika", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8486), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8487), "Wortel", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8491), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8492), "Ajuin", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8498), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8499), "Kippenbouillon", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8503), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8504), "Olijfolie", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8508), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8509), "Champignons", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8518), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8519), "Gemalen kaas", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8523), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8524), "Spaghetti", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8528), new DateTime(2022, 11, 24, 8, 48, 58, 364, DateTimeKind.Utc).AddTicks(8528), "Courgette", new Guid("00000000-0000-0000-0000-000000000011") }
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
