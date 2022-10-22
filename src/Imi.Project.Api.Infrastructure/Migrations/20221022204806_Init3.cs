using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                columns: new[] { "Id", "CreatedOn", "Email", "LastEditedOn" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9314), "admin@admin.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9315) },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9318), "woutercallewaert@gmail.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9319) },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9321), "jjameson@hotmail.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9323) },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9325), "tigbiddies@xxx.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9326) },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9329), "allthebutz@hotmail.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9330) },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9332), "ikloopindiestrond@gagmaker.net", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9334) },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9336), "olklo@gmail.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9338) },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9340), "wsmets1991@hotmail.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9341) },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9383), "maarten.raviola@gmail.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9385) },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9388), "toiletbril@lolbroek.com", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9389) }
                });

            migrationBuilder.InsertData(
                table: "Ingedrients",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9169), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9170), "Melk", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9172), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9173), "Laurier", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9174), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9175), "Gehakt", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9176), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9176), "Tomatenpuree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9178), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9178), "Boter", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9180), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9180), "Paprika", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9182), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9182), "Wortel", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9184), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9184), "Ajuin", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9186), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9186), "Kippenbouillon", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9187), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9188), "Olijfolie", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9189), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9189), "Champignons", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9192), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9192), "Gemalen kaas", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9194), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9194), "Spaghetti", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9196), new DateTime(2022, 10, 22, 20, 48, 5, 970, DateTimeKind.Utc).AddTicks(9196), "Courgette", new Guid("00000000-0000-0000-0000-000000000011") }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "Description", "LastEditedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9218), "Dit recept test de werking van dit recept.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9253), "Testrecept", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9258), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9259), "Witte saus", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9262), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9263), "Gemarineerde brochetten", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9266), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9268), "Champignonsoep", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9271), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9272), "Gehaktbrood met bonen en patatten", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9275), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9277), "Hamburger met wortel en patatten", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9280), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9281), "Viskroketjes met gebakken aardappelen", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9284), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9285), "Grillworst met puree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9288), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9289), "Spaghetti bolognaise", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9292), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 10, 22, 22, 48, 5, 970, DateTimeKind.Local).AddTicks(9294), "Ongelooflijk goed gerecht", new Guid("00000000-0000-0000-0000-000000000010") }
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
