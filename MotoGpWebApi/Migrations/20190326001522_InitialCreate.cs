using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotoGpWebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Country = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Length = table.Column<short>(type: "smallint", nullable: false),
                    NumberOfCurves = table.Column<byte>(type: "tinyint", nullable: false),
                    Width = table.Column<byte>(type: "tinyint", nullable: false),
                    StraightLonger = table.Column<short>(type: "smallint", nullable: false),
                    RaceLapRecord = table.Column<TimeSpan>(type: "time(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    CircuitId = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CircuitEvent",
                        column: x => x.CircuitId,
                        principalTable: "Circuits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CircuitId",
                table: "Events",
                column: "CircuitId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Circuits");
        }
    }
}
