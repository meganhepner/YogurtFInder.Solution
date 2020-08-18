using Microsoft.EntityFrameworkCore.Migrations;

namespace YogurtFinder.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Yogurts",
                columns: new[] { "YogurtId", "Blended", "Brand", "Calories", "Carbs", "Fat", "Flavor", "Protein", "Sugar", "Type" },
                values: new object[,]
                {
                    { 1, false, "Ellenos", 360, 38, 17, "key lime", 16, 30, "greek" },
                    { 2, false, "Brown Cow", 130, 11, 3, "plain", 8, 7, "cream top" },
                    { 3, true, "Siggi", 140, 11, 5, "coffee", 13, 8, "icelandic" },
                    { 4, false, "CoCoYo", 90, 8, 6, "vanilla", 1, 2, "dairy free" },
                    { 5, false, "Chobani Flip", 190, 24, 5, "cookie dough", 11, 21, "dessert, greek" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yogurts",
                keyColumn: "YogurtId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Yogurts",
                keyColumn: "YogurtId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Yogurts",
                keyColumn: "YogurtId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Yogurts",
                keyColumn: "YogurtId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Yogurts",
                keyColumn: "YogurtId",
                keyValue: 5);
        }
    }
}
