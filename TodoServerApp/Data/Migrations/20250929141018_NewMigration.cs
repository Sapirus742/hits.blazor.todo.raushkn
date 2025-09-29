using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 19, 10, 17, 752, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 19, 10, 17, 752, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 19, 10, 17, 752, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 19, 10, 17, 752, DateTimeKind.Local).AddTicks(3198));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 15, 8, 16, 707, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 15, 8, 16, 707, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 15, 8, 16, 707, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 29, 15, 8, 16, 707, DateTimeKind.Local).AddTicks(6553));
        }
    }
}
