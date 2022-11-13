using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class IdentityUpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUserClaim<string>",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaim<string>", x => x.Id);
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HasApprovedTermsAndConditions = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                table: "IdentityUserClaim<string>",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 11, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "user", "11" },
                    { 12, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "refuser", "12" },
                    { 13, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "admin", "13" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "Description", "LastEditedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9328), "Dit recept test de werking van dit recept.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9385), "Testrecept", null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9387), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9389), "Witte saus", null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9391), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9393), "Gemarineerde brochetten", null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9395), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9397), "Champignonsoep", null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9399), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9401), "Gehaktbrood met bonen en patatten", null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9432), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9433), "Hamburger met wortel en patatten", null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9436), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9438), "Viskroketjes met gebakken aardappelen", null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9440), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9442), "Grillworst met puree", null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9444), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9446), "Spaghetti bolognaise", null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9448), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 11, 13, 20, 24, 19, 179, DateTimeKind.Local).AddTicks(9450), "Ongelooflijk goed gerecht", null }
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
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0593622a-9e80-468f-89bc-af7d070f17c1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "69b9ac5f-5634-49b4-af4b-69076f5ea69c", "jjameson@hotmail.com", false, false, false, null, null, null, null, null, null, false, "cb5d5e01-5094-46a2-95c1-e75401150b19", false, null },
                    { "11", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "41d7b4ef-ac5a-4279-88c5-a7287be64545", "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", null, "AQAAAAEAACcQAAAAEC6qtn9fJkNX0Qp4x7h7bogK0MzlEv4W8lPIhArHPLSYYJPGpRmdWJfxQuuhlJd3mw==", null, false, "951ae934-0857-4431-a107-56be4980f0e4", false, "ImiUser" },
                    { "12", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc7d142d-e094-4b97-9d20-78aeb69bafac", "refuser@imi.be", true, false, false, null, "REFUSER@IMI.BE", "IMIREFUSER", null, "AQAAAAEAACcQAAAAECWn+Bd1w3IgchQjKW8686ZG3rzwnZLpKK9ZiPl0vTpLkOkOgAJ2mPJZNRTYIGgSoQ==", null, false, "7fe0a724-9604-4e29-86fa-0f9d490cdd42", false, "ImiRefuser" },
                    { "13", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "abbfdaed-c748-4766-a909-31313b60c056", "admin@imi.be", true, false, false, null, "ADMIN@IMI.BE", "IMIADMIN", null, "AQAAAAEAACcQAAAAEKt7wODtdskTKunsPXTNp4ngaxpNMsUZlEzhKYuqbD1W92FU+t8579gBSnh3GYNf/A==", null, false, "d6077d8c-9c90-416b-87d2-f37638076940", false, "ImiAdmin" },
                    { "42123969-5624-40d7-8f66-6360fcccabeb", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "03856461-a1cc-4300-a521-4d57a1282bf1", "maarten.raviola@gmail.com", false, false, false, null, null, null, null, null, null, false, "855bac0b-3610-4d6a-8309-eb963f46d9c0", false, null },
                    { "448567be-3806-44b4-ad1f-814c0ed13392", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "15c5ca31-1a7f-49db-9ea9-c41670f4ef9a", "olklo@gmail.com", false, false, false, null, null, null, null, null, null, false, "edd214cf-eecb-458c-9311-a4f1de5b759a", false, null },
                    { "b0b420d1-3745-4c8a-8629-6fa841d5f38a", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "754e6644-d8a8-41a6-a948-4fe2ccb6d155", "tigbiddies@xxx.com", false, false, false, null, null, null, null, null, null, false, "1f0d69ac-330b-4909-97a1-54e08b0ca3f4", false, null },
                    { "bf4413fe-2af6-4083-a80d-7c5ff82a6dde", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8efc4202-38ef-43dc-8b34-2b37818455b7", "woutercallewaert@gmail.com", false, false, false, null, null, null, null, null, null, false, "e86022cb-eb6c-41a4-9021-eb7243ee53fe", false, "Yusifer" },
                    { "d410fc48-afef-4284-997d-45d245758e11", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b26113a8-1b79-4cf9-8907-7702cbf8c5bb", "toiletbril@lolbroek.com", false, false, false, null, null, null, null, null, null, false, "1b72bc20-de71-4034-9387-aefa5c3de24a", false, null },
                    { "e1c0a5cc-7b2e-473d-8b25-ef3dc541ad7c", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2844862c-4958-43b2-a1c3-cceac53d2dd7", "admin@admin.com", false, true, false, null, null, null, "Test123?", null, null, false, "b30e274b-a145-4307-8633-7656c0faa0e9", false, "Admin" },
                    { "e5e29657-d10f-47de-892d-cbf1e95b2ef3", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "753ff2ee-f847-4043-a184-de571217edaa", "allthebutz@hotmail.com", false, false, false, null, null, null, null, null, null, false, "77277116-8ca1-4495-b0a5-cd5377391633", false, null },
                    { "ea0a5285-95f8-40d0-a5fa-9317f6d93085", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c357b48b-936f-47af-b2a0-6ffb16808937", "ikloopindiestrond@gagmaker.net", false, false, false, null, null, null, null, null, null, false, "9d24fd5b-97fe-4396-af11-ce6e4501535e", false, null },
                    { "f7d5fbc2-1159-408d-ab6d-a48d1f713d99", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c734ae91-a8e6-4195-bf18-17688096cbd2", "wsmets1991@hotmail.com", false, false, false, null, null, null, null, null, null, false, "4c8433a8-66ec-4d8b-b132-358c2c2b89db", false, null }
                });

            migrationBuilder.InsertData(
                table: "Ingedrients",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9282), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9283), "Melk", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9285), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9285), "Laurier", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9287), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9287), "Gehakt", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9289), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9289), "Tomatenpuree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9291), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9291), "Boter", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9293), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9293), "Paprika", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9295), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9295), "Wortel", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9297), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9297), "Ajuin", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9299), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9299), "Kippenbouillon", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9301), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9301), "Olijfolie", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9303), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9303), "Champignons", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9306), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9306), "Gemalen kaas", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9308), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9308), "Spaghetti", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9310), new DateTime(2022, 11, 13, 19, 24, 19, 179, DateTimeKind.Utc).AddTicks(9310), "Courgette", new Guid("00000000-0000-0000-0000-000000000011") }
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
                name: "IdentityUserClaim<string>");

            migrationBuilder.DropTable(
                name: "IngedrientRecipe");

            migrationBuilder.DropTable(
                name: "Ingedrients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasure");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
