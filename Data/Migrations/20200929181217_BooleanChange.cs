using Microsoft.EntityFrameworkCore.Migrations;

namespace myPantry.Data.Migrations
{
    public partial class BooleanChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Recipe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Recipe",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
