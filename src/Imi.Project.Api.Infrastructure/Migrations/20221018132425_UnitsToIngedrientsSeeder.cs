using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UnitsToIngedrientsSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UnitOfMeasureId",
                table: "Ingedrients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7653), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7656), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7659), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7659), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7661), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7661), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7663), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7663), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7665), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7665), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7674), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7674), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7676), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7676), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7678), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7678), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7681), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7682), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7684), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7685), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7718), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7768), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7773), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7777), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7782), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7786), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7791), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7795), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7804), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.InsertData(
                table: "UnitsOfMeasure",
                columns: new[] { "Id", "MeasureUnit" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), " " });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7830), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7835), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7840), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7844), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7849), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7856), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7860), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7865), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7870), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7874), new DateTime(2022, 10, 18, 15, 24, 25, 324, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7667), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7668), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7669), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7670), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7672), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7672), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7687), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7687), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.CreateIndex(
                name: "IX_Ingedrients_UnitOfMeasureId",
                table: "Ingedrients",
                column: "UnitOfMeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingedrients_UnitsOfMeasure_UnitOfMeasureId",
                table: "Ingedrients",
                column: "UnitOfMeasureId",
                principalTable: "UnitsOfMeasure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingedrients_UnitsOfMeasure_UnitOfMeasureId",
                table: "Ingedrients");

            migrationBuilder.DropIndex(
                name: "IX_Ingedrients_UnitOfMeasureId",
                table: "Ingedrients");

            migrationBuilder.DeleteData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DropColumn(
                name: "UnitOfMeasureId",
                table: "Ingedrients");

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7537), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7541), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7543), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7545), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7546), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7548), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7550), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7551), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7553), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7554), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7557), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7561), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7563), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7564), new DateTime(2022, 10, 18, 9, 48, 55, 465, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7588), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7633), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7638), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7642), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7647), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7652), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7656), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7661), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7665), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7697), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7702), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7706), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7711), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7715), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7725), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7730), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7734), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7739), new DateTime(2022, 10, 18, 11, 48, 55, 465, DateTimeKind.Local).AddTicks(7741) });
        }
    }
}
