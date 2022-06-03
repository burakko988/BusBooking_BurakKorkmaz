using Microsoft.EntityFrameworkCore.Migrations;

namespace BiletRezervasyon.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    BusId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusPlaque = table.Column<string>(type: "TEXT", nullable: true),
                    BusSeatCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    BusDriverFullName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.BusId);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstTerminal = table.Column<string>(type: "TEXT", nullable: true),
                    Terminal1 = table.Column<string>(type: "TEXT", nullable: true),
                    Terminal2 = table.Column<string>(type: "TEXT", nullable: true),
                    Terminal3 = table.Column<string>(type: "TEXT", nullable: true),
                    Terminal4 = table.Column<string>(type: "TEXT", nullable: true),
                    Terminal5 = table.Column<string>(type: "TEXT", nullable: true),
                    LastTerminal = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    Hour = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    BusId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                    table.ForeignKey(
                        name: "FK_Routes_Buses_BusId",
                        column: x => x.BusId,
                        principalTable: "Buses",
                        principalColumn: "BusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PassengerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    PassgerLastName = table.Column<string>(type: "TEXT", nullable: true),
                    PassengerMail = table.Column<string>(type: "TEXT", nullable: true),
                    PassengerPhone = table.Column<string>(type: "TEXT", nullable: true),
                    PassengerIdentity = table.Column<string>(type: "TEXT", nullable: true),
                    PassengerGender = table.Column<string>(type: "TEXT", nullable: true),
                    SeatNo = table.Column<int>(type: "INTEGER", nullable: false),
                    BoardingPoint = table.Column<string>(type: "TEXT", nullable: true),
                    Destination = table.Column<string>(type: "TEXT", nullable: true),
                    PnrNo = table.Column<string>(type: "TEXT", nullable: true),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false),
                    BusId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Buses_BusId",
                        column: x => x.BusId,
                        principalTable: "Buses",
                        principalColumn: "BusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RouteId",
                table: "Cities",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_BusId",
                table: "Routes",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BusId",
                table: "Tickets",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RouteId",
                table: "Tickets",
                column: "RouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Buses");
        }
    }
}
