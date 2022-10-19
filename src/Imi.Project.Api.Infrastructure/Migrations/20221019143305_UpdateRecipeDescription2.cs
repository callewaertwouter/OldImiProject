using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateRecipeDescription2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4725), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4733), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4736), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4739), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4743), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4746), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4748), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4751), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4820), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4823), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4825), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4829), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4835), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4839), new DateTime(2022, 10, 19, 14, 33, 4, 949, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4885), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4987), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4994), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5002), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5008), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5025), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5032), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5077), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5087), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5093), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5099), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5105), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5112), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5118), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5124), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5134), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5140), new DateTime(2022, 10, 19, 16, 33, 4, 949, DateTimeKind.Local).AddTicks(5142) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3266), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3270), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3272), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3274), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3276), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3278), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3280), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3282), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3284), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3286), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3288), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3290), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3292), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3294), new DateTime(2022, 10, 19, 14, 28, 29, 339, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3318), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3364), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3369), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3374), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3393), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3423), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3428), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3433), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3437), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3441), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3446), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3450), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3454), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3459), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3463), new DateTime(2022, 10, 19, 16, 28, 29, 339, DateTimeKind.Local).AddTicks(3465) });
        }
    }
}
