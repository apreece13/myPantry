using Microsoft.EntityFrameworkCore.Migrations;

namespace myPantry.Data.Migrations
{
    public partial class UserIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_ProductUserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Users_UserId",
                table: "Recipe");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_UserId",
                table: "Recipe");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Recipe",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductUserId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_UserId1",
                table: "Recipe",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_ProductUserId",
                table: "Products",
                column: "ProductUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_AspNetUsers_UserId1",
                table: "Recipe",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_ProductUserId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_AspNetUsers_UserId1",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_UserId1",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ProductUserId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_UserId",
                table: "Recipe",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_ProductUserId",
                table: "Products",
                column: "ProductUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Users_UserId",
                table: "Recipe",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
