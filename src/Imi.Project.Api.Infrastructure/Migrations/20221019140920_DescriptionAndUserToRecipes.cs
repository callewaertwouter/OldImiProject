using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class DescriptionAndUserToRecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Recipes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Recipes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4690), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4697), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4699), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4701), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4703), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4705), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4707), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4709), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4711), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4713), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4715), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4717), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4719), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4721), new DateTime(2022, 10, 19, 14, 9, 20, 155, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4745), "Dit recept test de werking van dit recept.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4793), "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak verdwijnt.Breng op smaak met nootmuskaat, peper en zout.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4797), "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4802), "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met wat peper van de molen en een snuif zout.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4807), "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4812), "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4817), "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4822), "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4826), "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter.2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is.3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise.4) Serveer met gemalen kaas.5) Bon appetit.", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedBy", "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4831), "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!", new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4890), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4895), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4899), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4903), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4907), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4911), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4920), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4924), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4929), new DateTime(2022, 10, 19, 16, 9, 20, 155, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5796), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5799), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5801), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5803), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5805), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5807), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5809), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5811), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5813), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5815), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5818), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5820), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5822), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5824), new DateTime(2022, 10, 19, 10, 11, 40, 237, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5844), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5896), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5900), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5904), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5909), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5913), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5917), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5922), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5926), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "Description", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5930), null, new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5990), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5996), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6005), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6009), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6013), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6018), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6022), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6026), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(6033) });
        }
    }
}
