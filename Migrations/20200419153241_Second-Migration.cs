using Microsoft.EntityFrameworkCore.Migrations;

namespace BreakfastWebAppV2.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupants_Rooms_RoomNumber1",
                table: "Occupants");

            migrationBuilder.DropIndex(
                name: "IX_Occupants_RoomNumber1",
                table: "Occupants");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Occupants");

            migrationBuilder.DropColumn(
                name: "RoomNumber1",
                table: "Occupants");

            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "Occupants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 1,
                column: "RoomID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 2,
                column: "RoomID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 3,
                column: "RoomID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 4,
                column: "RoomID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 5,
                column: "RoomID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 6,
                column: "RoomID",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Occupants_RoomID",
                table: "Occupants",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupants_Rooms_RoomID",
                table: "Occupants",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupants_Rooms_RoomID",
                table: "Occupants");

            migrationBuilder.DropIndex(
                name: "IX_Occupants_RoomID",
                table: "Occupants");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "Occupants");

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                table: "Occupants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber1",
                table: "Occupants",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 1,
                column: "RoomNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 2,
                column: "RoomNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 3,
                column: "RoomNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 4,
                column: "RoomNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 5,
                column: "RoomNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Occupants",
                keyColumn: "ID",
                keyValue: 6,
                column: "RoomNumber",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Occupants_RoomNumber1",
                table: "Occupants",
                column: "RoomNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupants_Rooms_RoomNumber1",
                table: "Occupants",
                column: "RoomNumber1",
                principalTable: "Rooms",
                principalColumn: "RoomNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
