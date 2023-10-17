using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shamazon.Data.Migrations
{
    public partial class mssqllocal_migration_371 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Item");

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemExtendedDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
