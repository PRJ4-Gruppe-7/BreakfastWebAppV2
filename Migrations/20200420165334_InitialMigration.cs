using Microsoft.EntityFrameworkCore.Migrations;

namespace BreakfastWebAppV2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckedInAdult", "CheckedInChildren" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CheckedInAdult", "CheckedInChildren" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckedInChildren",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckedInAdult", "CheckedInChildren" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CheckedInAdult", "CheckedInChildren" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckedInChildren",
                value: 2);
        }
    }
}
