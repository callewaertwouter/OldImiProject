using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class IngedrientsToRecipesJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

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
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000009") }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngedrients",
                columns: new[] { "IngedrientId", "RecipeId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000010") });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5844), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5896), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5904), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5909), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5913), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5917), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5922), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5926), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 10, 19, 12, 11, 40, 237, DateTimeKind.Local).AddTicks(5932) });

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

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngedrients_IngedrientId",
                table: "RecipeIngedrients",
                column: "IngedrientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngedrients");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7653), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7659), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7661), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7663), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7665), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7667), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7669), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7672), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7674), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7676), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7678), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7681), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7684), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Ingedrients",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "LastEditedOn" },
                values: new object[] { new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7687), new DateTime(2022, 10, 18, 13, 24, 25, 324, DateTimeKind.Utc).AddTicks(7687) });

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
        }
    }
}
