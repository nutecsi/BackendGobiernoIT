using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class JobPosition0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobPositionId",
                table: "CompanyUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_JobPositionId",
                table: "CompanyUsers",
                column: "JobPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUsers__GenericLists_JobPositionId",
                table: "CompanyUsers",
                column: "JobPositionId",
                principalTable: "_GenericLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUsers__GenericLists_JobPositionId",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_JobPositionId",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "JobPositionId",
                table: "CompanyUsers");
        }
    }
}
