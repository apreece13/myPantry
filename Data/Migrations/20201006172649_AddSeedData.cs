using Microsoft.EntityFrameworkCore.Migrations;

namespace myPantry.Data.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_AspNetUsers_UserId1",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_UserId1",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Recipe");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "RecipeUrl",
                table: "Recipe",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductType",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProductImage",
                table: "Products",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "ccb95e0b-812f-4bee-a248-6f5d27ef1f18", "Users", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEAyOcDhufnZFKJTdDinwmbhnIUvHm/9tUsFI0Xa3Ig0nGYAHGa2iOQaAxq0I/ERihA==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { 1, "Pantry" },
                    { 2, "Fridge" },
                    { 3, "Freezer" },
                    { 4, "Shopping List" }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Carbohydrates" },
                    { 2, "Fruits" },
                    { 3, "Vegtables" },
                    { 4, "Beef" },
                    { 5, "Fish" },
                    { 6, "Poultry" },
                    { 7, "Dairy/Alternatives" },
                    { 8, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "LocationId", "Name", "ProductImage", "ProductTypeId", "ProductUserId", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 6, 1, "Sourdough Bread", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 1, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 20, 2, "Grape Jelly", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 8, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 7, 2, "Eggs", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 8, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, 1, "Peanut Butter", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 8, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 1, 1, "Honey", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 8, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 10, 2, "Cheddar Cheese", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 7, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, 2, "Butter", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 7, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 5, 2, "Almond Milk", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 7, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 25, 3, "Salmon", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 5, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 9, 2, "Ground Beef", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 4, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 24, 2, "V8", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 3, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 17, 2, "Tomato", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 3, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 21, 3, "Fish Sticks", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 5, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 14, 2, "Carrots", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 3, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 15, 1, "Hamburger Buns", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 1, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 19, 2, "Tortillas", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 1, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 16, 2, "Lettuce", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 3, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, 3, "Banana", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 2, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 18, 2, "Apples", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 2, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, 3, "Frozen Strawberries", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 2, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 23, 2, "Blackberries", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 2, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 11, 2, "Red Peppers", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 3, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 12, 2, "Green Peppers", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 3, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 13, 1, "Onions", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 3, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 22, 2, "Blueberries", "https://static6.depositphotos.com/1052036/548/v/950/depositphotos_5487922-stock-illustration-trash-can.jpg", 2, null, 2, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "Description", "Name", "RecipeUrl", "UserId" },
                values: new object[,]
                {
                    { 7, "Beef and cheese in a steamed tortilla shell. Better than Taco Bell.", "Beef Tacos", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 1, "A delcious smoothie with stawberries, bananas, honey, peanut butter, and almond milk.", "Strawberry Banana Smoothie", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, "Classic breakfast of two eggs and a piece of sourdough bread, toasted.", "Eggs and Toast", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, "Peanut butter and grape jelly on sourdough bread.", "PB&J", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, "A combination of ground beef, cheddar cheese, eggs, onions and peppers rolled up in a tortilla.", "Breakfast Burrito", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 5, "Ground beef, V8, onions, peppers, carrots, tomatoes, and a little cheddar cheese on top make this Fall staple", "Chili", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 6, "6 month old frozen fish sticks with cheddar cheese on a tortilla. I guess it is edible?", "Fish Tacos", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, "Patty out some ground beef and light up the grill. Ground beef, cheddar cheese, lettuce, tomato and onion on Kroger brand hamburger buns make this burger to die for.", "Cheeseburger", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQcaD7i-mv_DcouV4sn-7xnIv1cE8Rh0ShVJA&usqp=CAU", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "RecipeProducts",
                columns: new[] { "Id", "ProductId", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 22, 13, 5 },
                    { 23, 11, 5 },
                    { 24, 12, 5 },
                    { 25, 14, 5 },
                    { 26, 17, 5 },
                    { 27, 10, 5 },
                    { 28, 21, 6 },
                    { 21, 24, 5 },
                    { 29, 19, 6 },
                    { 31, 9, 7 },
                    { 32, 10, 7 },
                    { 33, 19, 7 },
                    { 34, 9, 8 },
                    { 35, 10, 8 },
                    { 36, 16, 8 },
                    { 37, 17, 8 },
                    { 30, 10, 6 },
                    { 38, 13, 8 },
                    { 20, 9, 5 },
                    { 18, 12, 4 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 1, 1 },
                    { 7, 6, 2 },
                    { 8, 7, 2 },
                    { 19, 19, 4 },
                    { 9, 8, 2 },
                    { 11, 2, 3 },
                    { 12, 20, 3 },
                    { 13, 9, 4 },
                    { 14, 10, 4 },
                    { 15, 7, 4 },
                    { 16, 13, 4 },
                    { 17, 11, 4 },
                    { 10, 6, 3 },
                    { 39, 15, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_UserId",
                table: "Recipe",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_AspNetUsers_UserId",
                table: "Recipe",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_AspNetUsers_UserId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_UserId",
                table: "Recipe");

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RecipeProducts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "RecipeUrl",
                table: "Recipe");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Recipe",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Recipe",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "ProductType",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "ProductImage",
                table: "Products",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_UserId1",
                table: "Recipe",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_AspNetUsers_UserId1",
                table: "Recipe",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
