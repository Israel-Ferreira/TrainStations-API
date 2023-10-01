using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainStationsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddZipCodeToAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Address",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Address");
        }
    }
}
