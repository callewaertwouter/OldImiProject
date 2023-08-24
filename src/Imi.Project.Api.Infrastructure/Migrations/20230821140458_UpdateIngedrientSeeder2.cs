using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateIngedrientSeeder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingedrients_UnitsOfMeasure_UnitOfMeasureId",
                table: "Ingedrients");

            migrationBuilder.DropIndex(
                name: "IX_Ingedrients_UnitOfMeasureId",
                table: "Ingedrients");

            migrationBuilder.DropColumn(
                name: "UnitOfMeasureId",
                table: "Ingedrients");

            migrationBuilder.AddColumn<string>(
                name: "UnitOfMeasure",
                table: "Ingedrients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc53111b-5006-4751-a055-b2a04b2696d6", "AQAAAAEAACcQAAAAEKHiB/54C/FpuS0Y897b4T+ltxPPmTBav12GfnxaKhWvneTRt7+0/etKY3qeWozqXg==", "49937fc2-58c0-4e87-aa3d-d6235553267b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32576220-3ef1-43c6-aa25-92ec2cd6fa97", "a1196167-1402-42cd-8c4b-8d70f862fa60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d75ae1cd-68fa-4377-81f3-3d3d81e417ed", "AQAAAAEAACcQAAAAEFojxb38D7eFmutmk9JpEFXHEQNNPtpF6aSMm8MYZgypKZs5rZAptRH2gGBwUcr4tg==", "84dd44a5-4660-42e0-a44a-c4a55b443d74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cbd8a88-187a-42eb-937e-7c45dd43ed09", "AQAAAAEAACcQAAAAEEe6J6l9kgkgIJBuj+4cbjs0BQe7++2NDNw2xNW/AeE23cptvAwATB/vJrylHwQbWw==", "6881b5b9-98b5-48d9-b05d-9a3d10155d13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4875ef3c-4af9-4c42-822d-0d2b12c533e1", "AQAAAAEAACcQAAAAEIC7QOmzV10ePq4T0uZBURo+fKjQDQ10Y/n4o03nwgOWElPDVSRhh8h9/0e04A+80w==", "dfc98414-d270-4ef8-adc4-fab694f91be3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de5d100c-942c-4ded-9fbe-bb5ce1ff686b", "AQAAAAEAACcQAAAAEPEiaFebRJ2RmjnCJolNAWngCvdwOExV9s8CAahCy5yxpkdsKwjqr9GRq/XMv4SQHw==", "cf42a9f6-e009-45de-97d9-4de1aa541dbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28fdf998-4c10-4538-8c56-1c59b275076e", "AQAAAAEAACcQAAAAEGNIPqy2Qk4efl0UnJjunZK9CeSlRsRVvgvrbN70E+RRABhwC8Jf5QcleSplTGH9gQ==", "f6d5c4fe-25b4-48e3-84e2-d14ab997fb37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fd32ec2-bb81-4df5-b2f8-f0441ae2c51c", "AQAAAAEAACcQAAAAEClHRaH7QrZUi+8wTL+vuU0Fe+7WG5s9dYLJOeeNdvlDjvt4RMadhho8iDKz+t5EhQ==", "be1efa08-ab1f-4623-afb9-b7e97a836a61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d1ab84f-0a7d-45c5-bb5d-44b1b5ae059c", "AQAAAAEAACcQAAAAEAkneS+0k+zOTZjj56pyjNh022FKD6Q3bBn8YdVAPeguzHx7wUV3oYI9jrKMuFtyEg==", "784284f4-fb20-4eab-95c8-934893124363" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "588f909d-3b5a-4ff0-b8d4-5e93bd520f1f", "AQAAAAEAACcQAAAAEEDHf9vRrI0H43g1MGI12lN6JeUceL7Of73I/3mOJrlY3xNBeTMTTeZBJ92MA7eczg==", "9fe5f080-fbd4-46b0-af77-85765360240e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54eeaaed-cbb8-4f3e-8ef6-81c21ae0af96", "AQAAAAEAACcQAAAAEMFbjYNjb6Ak+2oI89jkTLerW2WkK1BA3r72tPl9E94ONGlQw2ogp8Ti6PQ7l/8x6A==", "43ecf4af-01dd-43ae-a93a-5978d94c1e33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "802b5f97-d512-4c5f-b123-30f14c440f96", "AQAAAAEAACcQAAAAEDVkMD8XtzqFRFM8n+n7hwIIpxwIEfd5Zc/ahe7IqhXd3F7mECogndW7oGx7eOOAMQ==", "db7592f4-86f4-4285-88aa-e73627eec7a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15f54a44-da05-43d3-ac76-64a8f9632801", "AQAAAAEAACcQAAAAECYwifoPYXZpZp2ArB/RbfBIUvokAkVUTgkbMVAPrMMnPDW+aCiQ9p2OGCbofd/zUA==", "bbff954e-d377-477e-8e46-75834c90ce3e" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5652), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5653), "liter" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5655), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5655), "takjes" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5657), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5657), "kilo" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5658), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5659), "blik" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5660), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5660), "gram" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5662), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5662), "" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5663), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5664), "" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5665), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5665), "" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5666), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5667), "liter" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5668), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5668), "centiliter" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5670), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5670), "bakjes" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5672), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5673), "gram" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5675), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5675), "" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasure" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5676), new DateTime(2023, 8, 21, 14, 4, 58, 291, DateTimeKind.Utc).AddTicks(5677), "" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5704), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5751), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5802), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5807), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5812), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 8, 21, 16, 4, 58, 291, DateTimeKind.Local).AddTicks(5818) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitOfMeasure",
                table: "Ingedrients");

            migrationBuilder.AddColumn<Guid>(
                name: "UnitOfMeasureId",
                table: "Ingedrients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b03b57-b632-4601-9023-1c05c0a853bd", "AQAAAAEAACcQAAAAEGoGladwq8BgcKtqArmrRH20MaYEILMIpVu8DbMc7op0n2quPEVMu0mVC2qoKoK92Q==", "2b70592c-eb7e-479c-9c62-64bd30f989f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f437d35b-aa9b-4522-8cdd-9ab73e2b6468", "e96fb988-6eaa-4497-9681-e141df14f225" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8d4d457-b081-43a6-a1aa-91195dc569ab", "AQAAAAEAACcQAAAAEH7ki3K7ied96YjszVfbXZTgBOEd5qLrev3pd4lkBS15jZtCGaC8fPIqBymLG5A0tw==", "2c7ae452-c346-422d-a46d-8b562147bd60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32f1aa73-ef98-475c-8c52-fa123efd67f0", "AQAAAAEAACcQAAAAENfbg91gKnuFV5TmDdNJQ9mmrwDVXZnFlcpQ6AIGe23S/76Toov8dZIp2YMPssNv7w==", "2002a2d1-61e9-4bb0-ae69-43388e899e67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9efda31-761f-43c4-83bd-9fdac48d9176", "AQAAAAEAACcQAAAAENeZ38K8EZU75T0GBqguxEjz8s6f947TcEJxKsNhfcAvxG+KgFKxV3B7Xpc5ow152A==", "a0b0f4d1-c260-4f1a-8887-385e9fbcb0e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c72709bf-fb0e-46fe-b1a0-24d9f1e1c53d", "AQAAAAEAACcQAAAAEOwRBPb3eItxy+mCPxDS+e6CGTEJYoSO6Z61QMxd2rd0dLlHfwnmLbwBg+tYBLLI1w==", "1905b0cc-9050-471c-bb11-482b89f256da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a881a108-6b2b-4c6a-9727-f8802a2d6f1c", "AQAAAAEAACcQAAAAEKOpCyQqZga7Tv+NPNGOHQCc0rK5C31BBAVhAln3X5hju4mamBB3O1BrfEqjbACVWA==", "29ba1fd6-fcad-4def-837a-37a6c57c7fee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bd12edd-dbbe-404d-81b4-324effba04ce", "AQAAAAEAACcQAAAAEFrVksNAIXh8i8WiVc3G8sFercnOjpv5f9iLTYWSlihImz0TaqKTkio/+N5P5gjHyA==", "53bfc517-e729-4aec-8226-95b55759c00a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f4d3eb5-7695-4431-ba4a-c3cc4c462dfb", "AQAAAAEAACcQAAAAEABVkwRZ/wR4vQAZHXV/6ZGwS72WCMMnx7tvIS3SimDJLTpqx7ejjbf+nhtWPS+/+A==", "80e68475-d8bc-423e-9d27-ea067ab32ee1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db71c177-9161-4491-b94a-49f06ebb3295", "AQAAAAEAACcQAAAAEDt05icnoFQo+az7IRzJ0jv32nkjnQfK7FxJy2HYTn2hYcqG57HFH0oPGexbgawAvg==", "13af9ea9-a3f7-461b-ab13-86964a41c4a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5e9edaa-ea76-4040-91ae-576e876ae104", "AQAAAAEAACcQAAAAEKIEp7ldLXoZ4jweLAFvykWKf0k0S4yREZ6D2HjGoxv372YpRcm3AFZiDrYWWO0ABg==", "bbc38772-139b-4967-999b-f066620f49bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cb400d4-ecfa-403a-8f71-67878f6b8437", "AQAAAAEAACcQAAAAELfU6u+fOJ2NvwmM1urnEeH2DflwTVSoXu6xrpbIiKKzUgONEQKEb14trWlIdLs0DQ==", "9428d0ef-91bd-40ec-a319-71521696cd2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8698bf88-bd05-4681-88a6-852e1b5ed756", "AQAAAAEAACcQAAAAEC6MyX6kQaY78sliUJdPhWNebcBy2DC3lrvDJFbJH30c8qvjJANCBxB2dBksfl81IA==", "944a816b-1470-4be9-bcc7-04a3b7907d75" });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1914), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1915), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1917), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1917), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1919), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1919), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1921), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1921), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1923), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1923), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1925), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1925), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1927), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1927), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1929), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1929), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1931), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1931), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1933), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1933), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1935), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1935), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1938), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1939), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1940), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1941), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn", "UnitOfMeasureId" },
                values: new object[] { new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1965), new DateTime(2022, 11, 24, 20, 32, 40, 717, DateTimeKind.Utc).AddTicks(1965), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(1984), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2026), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2031), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2035), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2039), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2043), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2047), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2051), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2055), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2059), new DateTime(2022, 11, 24, 21, 32, 40, 717, DateTimeKind.Local).AddTicks(2060) });

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
    }
}
