using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class RequirementDefinitionCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "_RequirementDefinitions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX__RequirementDefinitions_CategoryId",
                table: "_RequirementDefinitions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK__RequirementDefinitions__GenericLists_CategoryId",
                table: "_RequirementDefinitions",
                column: "CategoryId",
                principalTable: "_GenericLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__RequirementDefinitions__GenericLists_CategoryId",
                table: "_RequirementDefinitions");

            migrationBuilder.DropIndex(
                name: "IX__RequirementDefinitions_CategoryId",
                table: "_RequirementDefinitions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "_RequirementDefinitions");
        }
    }
}
