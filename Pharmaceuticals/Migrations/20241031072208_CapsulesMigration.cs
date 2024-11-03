using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmaceuticals.Migrations
{
    /// <inheritdoc />
    public partial class CapsulesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Capsules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapsuleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Output = table.Column<int>(type: "int", nullable: false),
                    CapsuleSize = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MachineDimension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Capsules", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Capsules");
        }
    }
}
