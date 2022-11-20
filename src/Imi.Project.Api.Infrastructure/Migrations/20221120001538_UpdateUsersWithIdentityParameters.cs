using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateUsersWithIdentityParameters : Migration
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
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "Description", "LastEditedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1804), "Dit recept test de werking van dit recept.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1844), "Testrecept", null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1846), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1848), "Witte saus", null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1850), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1852), "Gemarineerde brochetten", null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1854), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1856), "Champignonsoep", null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1858), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1860), "Gehaktbrood met bonen en patatten", null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1862), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1864), "Hamburger met wortel en patatten", null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1866), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1868), "Viskroketjes met gebakken aardappelen", null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1870), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1872), "Grillworst met puree", null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1874), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1876), "Spaghetti bolognaise", null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1878), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 11, 20, 1, 15, 38, 364, DateTimeKind.Local).AddTicks(1880), "Ongelooflijk goed gerecht", null }
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
                    { "1", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9a9e6135-2253-4991-9583-6c55095409e9", "admin@admin.com", true, true, false, null, "ADMIN@ADMIN.COM", "ADMIN", null, "AQAAAAEAACcQAAAAECfdw1+X8LpN/n0UhDB/0VPCBBoRYOWMKaFSqbMic2a0XPhLC4efTQPQA+ccfYgnMg==", null, false, "903401b3-cd79-49bc-a331-57408e9d6178", false, "Admin" },
                    { "10", 0, new DateTime(2006, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8b2ec00-9766-42c0-976c-e586bc6b89fd", "toiletbril@gmail.com", true, true, false, null, "TOILETBRIL@GMAIL.COM", "TOITOITOILET", null, null, null, false, "82ffc399-b2f2-4642-b5be-c384d86a0986", false, "Toitoitoilet" },
                    { "11", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "667495bd-fbd9-46e6-90ce-91516379f689", "user@imi.be", true, true, false, null, "USER@IMI.BE", "IMIUSER", null, "AQAAAAEAACcQAAAAEHkrTVArYhiw4KMzQBzqC9F+KXc/VCt/5n+t463HYfxDtzZZ1YzEQTvanmNigIkqKg==", null, false, "d31449f9-b358-4778-8c13-cc3b5569c5c6", false, "ImiUser" },
                    { "12", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c7c3045-edb4-4f3a-9706-7133f217a845", "refuser@imi.be", true, false, false, null, "REFUSER@IMI.BE", "IMIREFUSER", null, "AQAAAAEAACcQAAAAEMRXU3g/tw9sGDlWKH2iTQKNOqaNnCFGZvcZuBPWzQl+oAyVI9CmNKuHn6rgt5KtGQ==", null, false, "813c6d26-d214-4f90-b198-4641d6cc28df", false, "ImiRefuser" },
                    { "13", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3fc73802-9ab6-4169-a4c2-4da553ba5072", "admin@imi.be", true, false, false, null, "ADMIN@IMI.BE", "IMIADMIN", null, "AQAAAAEAACcQAAAAEMi3a9Jep3gJDHzZbjb+qdLqpEGj1ssujumhR4dd7O3+ezLqGKNIiniI8NI/8ZqAhw==", null, false, "79ff060a-21ce-4be3-a569-70df32d1b238", false, "ImiAdmin" },
                    { "2", 0, new DateTime(1986, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "9ca857d1-442f-4207-a7bf-fe87c96277fc", "woutercallewaert@gmail.com", true, true, false, null, "WOUTERCALLEWAERT@GMAIL.COM", "YUSIFER", null, "AQAAAAEAACcQAAAAECWLFUG+pyEtiiCu8Em0SEGCyHN2jk/Zy5dbJ87g2Zqp8ELFReCfSEzg9NOyye9pPQ==", null, false, "f02b758a-316f-465b-98b3-92d70ea4c31e", false, "Yusifer" },
                    { "3", 0, new DateTime(1980, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "08a8b493-bb93-4e5d-b9b4-810f086c0923", "jjameson@hotmail.com", true, true, false, null, "JJAMESON@HOTMAIL.COM", "JJJ", null, "AQAAAAEAACcQAAAAEPtzn6todSZZWEGybVG/f7KRIG+8WyId1DHp2Z72s8Adrj1ap/V3up1ZN0FEd4XWfw==", null, false, "15819f11-7ccd-4378-94a2-7adbc98c682a", false, "JJJ" },
                    { "4", 0, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "771c09ec-9166-46af-bde3-8748f37a3c06", "tigbiddies@xxx.com", true, false, false, null, "TIGBIDDIES@XXX.COM", "BIGPP", null, "AQAAAAEAACcQAAAAED3c/zHxrb6+AHAvzDRCtvxFAVJxGcGl0VNxLT5n627BtB6piedpU9RWnFwTWgrl5g==", null, false, "3b1c07c5-9a66-4917-8483-53ccf6e86e78", false, "BigPP" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, new DateTime(1995, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "8c5ebee9-a57b-4afd-ae77-7e74962035ea", "allthebutz@hotmail.com", true, true, false, null, "ALLTHEBUTZ@HOTMAIL.COM", "ALLTHEB", null, "AQAAAAEAACcQAAAAEGfIxw/sntf45S7fAaxWlXYnQcaaiaOacj8t+KM6ETFOyrO0zwxafQH5C/TDatASTw==", null, false, "3269cf16-6ae7-499d-8fdc-754e9c97119d", false, "AlltheB" },
                    { "6", 0, new DateTime(2010, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "003de745-be4e-43a3-9bc3-ebbeb9b8a5fd", "ikloopindiestrond@gagmaker.net", true, true, false, null, "IKLOOPINDIESTROND@GAGMAKER.NET", "TAALJOKER", null, "AQAAAAEAACcQAAAAEPLd0GbXBz6V19nGaKfJd/1xzucg8PyQQmZr3a0srH9MYfJuNFik9gY+lSoF4KfuSQ==", null, false, "eb2be603-ac7c-4fbb-ba34-a77f66674e32", false, "Taaljoker" },
                    { "7", 0, new DateTime(1999, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "e351730f-a560-45aa-b67e-b55b4e13797b", "olklo@hotmail.com", true, true, false, null, "OLKLO@HOTMAIL.COM", "PALINGDROOL", null, "AQAAAAEAACcQAAAAECaZ4EnmjGwqvlZgoV0SwJooN5OYtrBe8+ZRCsfMFNRKKX0R6tFRSztQwfecpIVVeA==", null, false, "7b03d53e-6b04-4b76-873f-579c8a345e2c", false, "Palingdrool" },
                    { "8", 0, new DateTime(1991, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "38a20ce3-be36-40ef-ae3b-aab7b66ae68e", "wsmets1991@gmail.com", true, true, false, null, "WSMETS1991@GMAIL.COM", "WSMETS", null, "AQAAAAEAACcQAAAAEC+w/Tx67O8gcbA5qYADhBstpbZXASmPC7blr+3K73f9C25wA7ReSs2pMk0XN3ThCA==", null, false, "6e40c496-a069-4eaf-810e-d80ec5321c66", false, "WSmets" },
                    { "9", 0, new DateTime(1982, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "58b03a8d-12f8-4564-8129-72dfacdfd70e", "maarten.raviola@hotmail.com", true, true, false, null, "MAARTEN.RAVIOLA@HOTMAIL.COM", "MAVOLIA", null, "AQAAAAEAACcQAAAAEGWsWmc76M0d9AXBKpz5EbYLbX7CnjFrbCNPgtCc4mm8yZWn8RXOzpuGXngTXur2aw==", null, false, "d50cf963-487e-4a9b-b95a-807d79dae441", false, "Mavolia" }
                });

            migrationBuilder.InsertData(
                table: "Ingedrients",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1757), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1757), "Melk", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1759), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1760), "Laurier", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1761), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1762), "Gehakt", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1763), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1764), "Tomatenpuree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1765), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1766), "Boter", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1767), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1768), "Paprika", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1769), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1770), "Wortel", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1771), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1772), "Ajuin", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1773), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1774), "Kippenbouillon", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1775), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1776), "Olijfolie", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1777), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1778), "Champignons", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1781), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1782), "Gemalen kaas", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1783), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1784), "Spaghetti", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1785), new DateTime(2022, 11, 20, 0, 15, 38, 364, DateTimeKind.Utc).AddTicks(1786), "Courgette", new Guid("00000000-0000-0000-0000-000000000011") }
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
