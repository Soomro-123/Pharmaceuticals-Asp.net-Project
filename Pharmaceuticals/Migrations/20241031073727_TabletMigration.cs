using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmaceuticals.Migrations
{
    /// <inheritdoc />
    public partial class TabletMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiquidFillings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LiquidFillings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirPressure = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AirVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FillingRange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FillingSpeed = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidFillings", x => x.Id);
                });
        }
    }
}
