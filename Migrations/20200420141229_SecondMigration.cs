using Microsoft.EntityFrameworkCore.Migrations;

namespace BreakfastWebAppV2.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CheckedInChildren",
                table: "Occupants",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CheckedInAdult",
                table: "Occupants",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

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
            migrationBuilder.AlterColumn<int>(
                name: "CheckedInChildren",
                table: "Occupants",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CheckedInAdult",
                table: "Occupants",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);
        }
    }
}
