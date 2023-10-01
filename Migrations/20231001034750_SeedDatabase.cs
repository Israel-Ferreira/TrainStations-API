using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainStationsAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PublicPlace = table.Column<string>(type: "TEXT", nullable: true),
                    AddressNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Neighbourhood = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Uf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    LineId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LineNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    Extension = table.Column<double>(type: "REAL", nullable: false),
                    Gauge = table.Column<double>(type: "REAL", nullable: false),
                    LineOperator = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.LineId);
                });

            migrationBuilder.CreateTable(
                name: "TrainStations",
                columns: table => new
                {
                    TrainStationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Code = table.Column<string>(type: "TEXT", nullable: true),
                    OpeningYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    StationAddressId = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainStations", x => x.TrainStationId);
                    table.ForeignKey(
                        name: "FK_TrainStations_Address_StationAddressId",
                        column: x => x.StationAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineTrainStation",
                columns: table => new
                {
                    LinesLineId = table.Column<long>(type: "INTEGER", nullable: false),
                    StationsTrainStationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineTrainStation", x => new { x.LinesLineId, x.StationsTrainStationId });
                    table.ForeignKey(
                        name: "FK_LineTrainStation_Lines_LinesLineId",
                        column: x => x.LinesLineId,
                        principalTable: "Lines",
                        principalColumn: "LineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineTrainStation_TrainStations_StationsTrainStationId",
                        column: x => x.StationsTrainStationId,
                        principalTable: "TrainStations",
                        principalColumn: "TrainStationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "LineId", "Color", "Extension", "Gauge", "LineNumber", "LineOperator" },
                values: new object[,]
                {
                    { 1L, "Azul", 20.199999999999999, 1.6000000000000001, 1, "Metrô SP" },
                    { 2L, "Verde", 14.699999999999999, 1.6000000000000001, 2, "Metrô SP" },
                    { 3L, "Vermelha", 22.0, 1.6000000000000001, 3, "Metrô SP" },
                    { 4L, "Amarela", 12.800000000000001, 1.4350000000000001, 4, "Via Quatro" },
                    { 5L, "Lilas", 20.0, 1.4350000000000001, 5, "Via Mobilidade" },
                    { 6L, "Rubi", 60.0, 1.6000000000000001, 7, "CPTM" },
                    { 7L, "Diamante", 41.600000000000001, 1.6000000000000001, 8, "Via Mobilidade" },
                    { 8L, "Esmeralda", 37.299999999999997, 1.6000000000000001, 9, "Via Mobilidade" },
                    { 9L, "Turquesa", 38.299999999999997, 1.6000000000000001, 10, "CPTM" },
                    { 10L, "Coral", 50.5, 1.6000000000000001, 11, "CPTM" },
                    { 11L, "Safira", 39.0, 1.6000000000000001, 12, "CPTM" },
                    { 12L, "Jade", 12.199999999999999, 1.6000000000000001, 13, "CPTM" },
                    { 13L, "Prata", 14.4, 0.0, 15, "Metrô SP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineTrainStation_StationsTrainStationId",
                table: "LineTrainStation",
                column: "StationsTrainStationId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainStations_StationAddressId",
                table: "TrainStations",
                column: "StationAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineTrainStation");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropTable(
                name: "TrainStations");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
