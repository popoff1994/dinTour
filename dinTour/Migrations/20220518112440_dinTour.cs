﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dinTour.Migrations
{
    public partial class dinTour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    VIPNr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pris = table.Column<int>(type: "int", nullable: false),
                    Menu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampagneMenu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPs", x => x.VIPNr);
                });

            migrationBuilder.CreateTable(
                name: "Begivenheder",
                columns: table => new
                {
                    BegivenhedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Varrighed = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Begivenheder", x => x.BegivenhedId);
                    table.ForeignKey(
                        name: "FK_Begivenheder_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Booknings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeltagerId = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Begivenheder_EventId",
                table: "Begivenheder",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Booknings_DeltagerId",
                table: "Booknings",
                column: "DeltagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Booknings_ParkeringId",
                table: "Booknings",
                column: "ParkeringId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Begivenheder");

            migrationBuilder.DropTable(
                name: "Booknings");

            migrationBuilder.DropTable(
                name: "VIPs");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Deltagere");

            migrationBuilder.DropTable(
                name: "Parkering");
        }
    }
}