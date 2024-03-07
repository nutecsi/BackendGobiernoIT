using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedGroupToCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_GroupId",
                table: "Companies",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies__Groups_GroupId",
                table: "Companies",
                column: "GroupId",
                principalTable: "_Groups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies__Groups_GroupId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_GroupId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Companies");
        }
    }
}
