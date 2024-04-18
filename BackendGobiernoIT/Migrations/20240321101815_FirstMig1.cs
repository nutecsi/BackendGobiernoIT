using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUsers_CompanyUsers_MainUserId1",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_MainUserId1",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "MainUserId",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "MainUserId1",
                table: "CompanyUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainUserId",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MainUserId1",
                table: "CompanyUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_MainUserId1",
                table: "CompanyUsers",
                column: "MainUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUsers_CompanyUsers_MainUserId1",
                table: "CompanyUsers",
                column: "MainUserId1",
                principalTable: "CompanyUsers",
                principalColumn: "Id");
        }
    }
}
