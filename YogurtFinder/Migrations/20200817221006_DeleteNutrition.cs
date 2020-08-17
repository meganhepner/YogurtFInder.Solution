using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YogurtFinder.Migrations
{
    public partial class DeleteNutrition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.AddColumn<string>(
                name: "Calories",
                table: "Yogurts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Carbs",
                table: "Yogurts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fat",
                table: "Yogurts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Protein",
                table: "Yogurts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sugar",
                table: "Yogurts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Yogurts");

            migrationBuilder.DropColumn(
                name: "Carbs",
                table: "Yogurts");

            migrationBuilder.DropColumn(
                name: "Fat",
                table: "Yogurts");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "Yogurts");

            migrationBuilder.DropColumn(
                name: "Sugar",
                table: "Yogurts");

            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    NutritionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Calories = table.Column<string>(nullable: true),
                    Carbs = table.Column<string>(nullable: true),
                    Fat = table.Column<string>(nullable: true),
                    Protein = table.Column<string>(nullable: true),
                    Sugar = table.Column<string>(nullable: true),
                    YogurtId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.NutritionId);
                    table.ForeignKey(
                        name: "FK_Nutrition_Yogurts_YogurtId",
                        column: x => x.YogurtId,
                        principalTable: "Yogurts",
                        principalColumn: "YogurtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_YogurtId",
                table: "Nutrition",
                column: "YogurtId");
        }
    }
}
