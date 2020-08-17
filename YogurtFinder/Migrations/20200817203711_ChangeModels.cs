using Microsoft.EntityFrameworkCore.Migrations;

namespace YogurtFinder.Migrations
{
    public partial class ChangeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yogurts_Nutrition_NutritionId1",
                table: "Yogurts");

            migrationBuilder.DropIndex(
                name: "IX_Yogurts_NutritionId1",
                table: "Yogurts");

            migrationBuilder.DropColumn(
                name: "NutritionId1",
                table: "Yogurts");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_YogurtId",
                table: "Nutrition",
                column: "YogurtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nutrition_Yogurts_YogurtId",
                table: "Nutrition",
                column: "YogurtId",
                principalTable: "Yogurts",
                principalColumn: "YogurtId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutrition_Yogurts_YogurtId",
                table: "Nutrition");

            migrationBuilder.DropIndex(
                name: "IX_Nutrition_YogurtId",
                table: "Nutrition");

            migrationBuilder.AddColumn<int>(
                name: "NutritionId1",
                table: "Yogurts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yogurts_NutritionId1",
                table: "Yogurts",
                column: "NutritionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Yogurts_Nutrition_NutritionId1",
                table: "Yogurts",
                column: "NutritionId1",
                principalTable: "Nutrition",
                principalColumn: "NutritionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
