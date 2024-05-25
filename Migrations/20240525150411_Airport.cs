using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airport.Migrations
{
    /// <inheritdoc />
    public partial class Airport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    INN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.id);
                    table.UniqueConstraint("AK_Airports_INN", x => x.INN);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    airportid = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speed = table.Column<double>(type: "float", nullable: false),
                    MaxDistance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Airplanes_Airports_airportid",
                        column: x => x.airportid,
                        principalTable: "Airports",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flight_hours = table.Column<byte>(type: "tinyint", nullable: false),
                    airplaneid = table.Column<int>(type: "int", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFlying = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Destinations_Airplanes_airplaneid",
                        column: x => x.airplaneid,
                        principalTable: "Airplanes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "id", "Count", "Distance", "INN", "address", "name" },
                values: new object[,]
                {
                    { 1, 0, 0, "1234567890", "г.Москва", "Шереметьево" },
                    { 2, 0, 0, "1234567892", "г.Москва", "Внуково" },
                    { 3, 0, 0, "1224567891", "г.Москва", "Домодедово" },
                    { 4, 0, 7484, "1214567891", "г.Токио", "АэропортТокио" },
                    { 5, 0, 2486, "1334567891", "г.Париж", "АэропортФранция" },
                    { 6, 0, 1796, "1434567891", "г.Анкара", "АэропортАнкара" },
                    { 7, 0, 7822, "1534567891", "г.Вашингтон", "АэропортСША" }
                });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "id", "MaxDistance", "Speed", "airportid", "name" },
                values: new object[,]
                {
                    { 1, 6400, 910.0, 1, "МС-21" },
                    { 2, 7200, 850.0, 2, "Ту-214" },
                    { 3, 6570, 835.0, 3, "Boeing 737 MAX" },
                    { 4, 13500, 900.0, 2, "Boeing 777X" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_airportid",
                table: "Airplanes",
                column: "airportid");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_airplaneid",
                table: "Destinations",
                column: "airplaneid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "Airports");
        }
    }
}
