using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class Casos4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases__GenericLists_ClassificationId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_ClassificationId",
                table: "Cases");

            migrationBuilder.AlterColumn<string>(
                name: "ClassificationId",
                table: "Cases",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClassificationId",
                table: "Cases",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ClassificationId",
                table: "Cases",
                column: "ClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases__GenericLists_ClassificationId",
                table: "Cases",
                column: "ClassificationId",
                principalTable: "_GenericLists",
                principalColumn: "Id");
        }
    }
}
