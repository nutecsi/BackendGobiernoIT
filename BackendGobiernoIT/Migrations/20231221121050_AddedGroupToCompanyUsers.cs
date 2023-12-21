using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedGroupToCompanyUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "CompanyUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_GroupId",
                table: "CompanyUsers",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUsers__Groups_GroupId",
                table: "CompanyUsers",
                column: "GroupId",
                principalTable: "_Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUsers__Groups_GroupId",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_GroupId",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "CompanyUsers");
        }
    }
}
