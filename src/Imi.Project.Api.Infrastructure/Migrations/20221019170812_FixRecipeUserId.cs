using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class FixRecipeUserId : Migration
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
                name: "RecipeIngedrients",
                columns: table => new
                {
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngedrientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngedrients", x => new { x.RecipeId, x.IngedrientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngedrients_Ingedrients_IngedrientId",
                        column: x => x.IngedrientId,
                        principalTable: "Ingedrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngedrients_Recipes_RecipeId",
                        column: x => x.RecipeId,
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
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9843), "admin@admin.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9846) },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9853), "woutercallewaert@gmail.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9854) },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9857), "jjameson@hotmail.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9859) },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9861), "tigbiddies@xxx.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9863) },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9865), "allthebutz@hotmail.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9867) },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9870), "ikloopindiestrond@gagmaker.net", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9871) },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9874), "olklo@gmail.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9876) },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9878), "wsmets1991@hotmail.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9880) },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9882), "maarten.raviola@gmail.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9884) },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9886), "toiletbril@lolbroek.com", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9888) }
                });

            migrationBuilder.InsertData(
                table: "Ingedrients",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name", "UnitOfMeasureId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9637), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9639), "Melk", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9643), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9644), "Laurier", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9646), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9647), "Gehakt", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9649), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9649), "Tomatenpuree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9651), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9651), "Boter", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9653), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9654), "Paprika", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9655), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9656), "Wortel", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9658), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9658), "Ajuin", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9660), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9661), "Kippenbouillon", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9663), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9663), "Olijfolie", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9665), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9665), "Champignons", new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9667), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9668), "Gemalen kaas", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9673), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9674), "Spaghetti", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9679), new DateTime(2022, 10, 19, 17, 8, 12, 37, DateTimeKind.Utc).AddTicks(9679), "Courgette", new Guid("00000000-0000-0000-0000-000000000011") }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "Description", "LastEditedOn", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9733), "Dit recept test de werking van dit recept.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9778), "Testrecept", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9782), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9783), "Witte saus", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9787), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9788), "Gemarineerde brochetten", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9791), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9793), "Champignonsoep", new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9796), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9798), "Gehaktbrood met bonen en patatten", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9801), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9803), "Hamburger met wortel en patatten", new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9806), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9807), "Viskroketjes met gebakken aardappelen", new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9810), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9812), "Grillworst met puree", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9815), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9817), "Spaghetti bolognaise", new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9820), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 10, 19, 19, 8, 12, 37, DateTimeKind.Local).AddTicks(9822), "Ongelooflijk goed gerecht", new Guid("00000000-0000-0000-0000-000000000010") }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngedrients",
                columns: new[] { "IngedrientId", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000010") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingedrients_UnitOfMeasureId",
                table: "Ingedrients",
                column: "UnitOfMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngedrients_IngedrientId",
                table: "RecipeIngedrients",
                column: "IngedrientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngedrients");

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
