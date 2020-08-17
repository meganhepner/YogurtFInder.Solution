using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YogurtFinder.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    NutritionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    YogurtId = table.Column<int>(nullable: false),
                    Protein = table.Column<string>(nullable: true),
                    Sugar = table.Column<string>(nullable: true),
                    Fat = table.Column<string>(nullable: true),
                    Carbs = table.Column<string>(nullable: true),
                    Calories = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.NutritionId);
                });

            migrationBuilder.CreateTable(
                name: "Yogurts",
                columns: table => new
                {
                    YogurtId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NutritionId = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Flavor = table.Column<string>(nullable: true),
                    Blended = table.Column<bool>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    NutritionId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yogurts", x => x.YogurtId);
                    table.ForeignKey(
                        name: "FK_Yogurts_Nutrition_NutritionId1",
                        column: x => x.NutritionId1,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yogurts_NutritionId1",
                table: "Yogurts",
                column: "NutritionId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yogurts");

            migrationBuilder.DropTable(
                name: "Nutrition");
        }
    }
}
