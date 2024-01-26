using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class jobroleColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2562), new DateTime(2024, 1, 31, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2580), new DateTime(2024, 1, 31, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2582), new DateTime(2024, 1, 31, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2584), new DateTime(2024, 1, 31, 13, 31, 45, 853, DateTimeKind.Local).AddTicks(2585) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5078), new DateTime(2024, 1, 29, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 1, 29, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5101), new DateTime(2024, 1, 29, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 1, 29, 10, 49, 41, 95, DateTimeKind.Local).AddTicks(5103) });
        }
    }
}
