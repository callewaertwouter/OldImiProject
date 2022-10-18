using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingedrients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingedrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ingedrients",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7537), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7540), "Melk" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7541), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7542), "Laurier" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7543), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7543), "Gehakt" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7545), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7545), "Tomatenpuree" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7546), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7547), "Boter" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7548), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7548), "Paprika" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7550), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7550), "Wortel" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7551), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7552), "Ajuin" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7553), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7553), "Kippenbouillon" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7554), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7555), "Olijfolie" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7557), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7557), "Champignons" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7561), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7562), "Gemalen kaas" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7563), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7563), "Spaghetti" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7564), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7565), "Courgette" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Title" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7588), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7630), "Testrecept" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7633), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7635), "Witte saus" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7640), "Gemarineerde brochetten" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7642), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7644), "Champignonsoep" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7647), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7649), "Gehaktbrood met bonen en patatten" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7652), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7653), "Hamburger met wortel en patatten" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7656), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7658), "Viskroketjes met gebakken aardappelen" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7661), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7662), "Grillworst met puree" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7665), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7667), "Spaghetti bolognaise" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7672), "Ongelooflijk goed gerecht" }
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
                    { new Guid("00000000-0000-0000-0000-000000000010"), "geen" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "Email", "LastEditedOn" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7697), "admin@admin.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7699) },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7702), "woutercallewaert@gmail.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7703) },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7706), "jjameson@hotmail.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7708) },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7711), "tigbiddies@xxx.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7713) },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7715), "allthebutz@hotmail.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7717) },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7720), "ikloopindiestrond@gagmaker.net", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7722) },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7725), "olklo@gmail.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7727) },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7730), "wsmets1991@hotmail.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7732) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "Email", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7734), "maarten.raviola@gmail.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "Email", "LastEditedOn" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7739), "toiletbril@lolbroek.com", new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7741) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
