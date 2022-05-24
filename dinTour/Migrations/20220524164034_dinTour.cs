using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dinTour.Migrations
{
    public partial class dinTour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Begivenheder",
                columns: table => new
                {
                    BegivenhedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Begivenheder", x => x.BegivenhedId);
                });

            migrationBuilder.CreateTable(
                name: "Deltagere",
                columns: table => new
                {
                    DeltagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tlf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deltagere", x => x.DeltagerId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AntalTilmeldte = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Parkering",
                columns: table => new
                {
                    ParkeringId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocupied = table.Column<bool>(type: "bit", nullable: false),
                    Pris = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkering", x => x.ParkeringId);
                });

            migrationBuilder.CreateTable(
                name: "VIPs",
                columns: table => new
                {
                    VIPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pris = table.Column<int>(type: "int", nullable: false),
                    Menu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPs", x => x.VIPId);
                });

            migrationBuilder.CreateTable(
                name: "Booknings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeltagerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkeringId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booknings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Booknings_Deltagere_DeltagerId",
                        column: x => x.DeltagerId,
                        principalTable: "Deltagere",
                        principalColumn: "DeltagerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booknings_Parkering_ParkeringId",
                        column: x => x.ParkeringId,
                        principalTable: "Parkering",
                        principalColumn: "ParkeringId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tilkøb",
                columns: table => new
                {
                    TlkøbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeltagerId = table.Column<int>(type: "int", nullable: false),
                    Menu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIPId = table.Column<int>(type: "int", nullable: false),
                    ChampagneMenu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tilkøb", x => x.TlkøbId);
                    table.ForeignKey(
                        name: "FK_Tilkøb_Deltagere_DeltagerId",
                        column: x => x.DeltagerId,
                        principalTable: "Deltagere",
                        principalColumn: "DeltagerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tilkøb_VIPs_VIPId",
                        column: x => x.VIPId,
                        principalTable: "VIPs",
                        principalColumn: "VIPId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booknings_DeltagerId",
                table: "Booknings",
                column: "DeltagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Booknings_ParkeringId",
                table: "Booknings",
                column: "ParkeringId");

            migrationBuilder.CreateIndex(
                name: "IX_Tilkøb_DeltagerId",
                table: "Tilkøb",
                column: "DeltagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tilkøb_VIPId",
                table: "Tilkøb",
                column: "VIPId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Begivenheder");

            migrationBuilder.DropTable(
                name: "Booknings");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Tilkøb");

            migrationBuilder.DropTable(
                name: "Parkering");

            migrationBuilder.DropTable(
                name: "Deltagere");

            migrationBuilder.DropTable(
                name: "VIPs");
        }
    }
}
