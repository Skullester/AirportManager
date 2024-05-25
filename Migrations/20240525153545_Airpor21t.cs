using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airport.Migrations
{
    /// <inheritdoc />
    public partial class Airpor21t : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airplanes_Airports_airportid",
                table: "Airplanes");

            migrationBuilder.AlterColumn<int>(
                name: "airportid",
                table: "Airplanes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Airplanes_Airports_airportid",
                table: "Airplanes",
                column: "airportid",
                principalTable: "Airports",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airplanes_Airports_airportid",
                table: "Airplanes");

            migrationBuilder.AlterColumn<int>(
                name: "airportid",
                table: "Airplanes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Airplanes_Airports_airportid",
                table: "Airplanes",
                column: "airportid",
                principalTable: "Airports",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
