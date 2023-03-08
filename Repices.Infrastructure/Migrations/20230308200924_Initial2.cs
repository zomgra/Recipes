using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repices.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientInfos",
                table: "IngredientInfos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IngredientInfos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientInfos",
                table: "IngredientInfos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientInfos_RecipeId",
                table: "IngredientInfos",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientInfos",
                table: "IngredientInfos");

            migrationBuilder.DropIndex(
                name: "IX_IngredientInfos_RecipeId",
                table: "IngredientInfos");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IngredientInfos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientInfos",
                table: "IngredientInfos",
                columns: new[] { "RecipeId", "IngredientId" });
        }
    }
}
