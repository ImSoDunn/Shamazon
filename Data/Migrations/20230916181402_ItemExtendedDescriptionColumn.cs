using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shamazon.Data.Migrations
{
    public partial class ItemExtendedDescriptionColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemExtendedDescription",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemExtendedDescription",
                table: "Item");
        }
    }
}
