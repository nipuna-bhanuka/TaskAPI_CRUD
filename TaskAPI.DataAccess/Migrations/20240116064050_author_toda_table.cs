using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class author_toda_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Martin Wickramasinghe" },
                    { 2, "Kumarathunga Munidasa" },
                    { 3, "Mahagama Sekara" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2024, 1, 16, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 1, 21, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2024, 1, 16, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8406), "Description 2", new DateTime(2024, 1, 21, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8407), 0, "Get books for school2" },
                    { 3, 3, new DateTime(2024, 1, 16, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8408), "Description 3", new DateTime(2024, 1, 21, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8409), 2, "Get books for school3" },
                    { 4, 1, new DateTime(2024, 1, 16, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8410), "Description 4", new DateTime(2024, 1, 21, 12, 10, 49, 799, DateTimeKind.Local).AddTicks(8411), 0, "Get books for school4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 15, 17, 0, 26, 7, DateTimeKind.Local).AddTicks(593), new DateTime(2024, 1, 20, 17, 0, 26, 7, DateTimeKind.Local).AddTicks(604) });
        }
    }
}
