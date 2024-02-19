using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class CambioEnInvSoftware : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Softwares__GenericLists_SoftwareId",
                table: "Softwares");

            migrationBuilder.DropIndex(
                name: "IX_Softwares_SoftwareId",
                table: "Softwares");

            migrationBuilder.DropColumn(
                name: "SoftwareId",
                table: "Softwares");

            migrationBuilder.AddColumn<string>(
                name: "SoftwareName",
                table: "Softwares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftwareName",
                table: "Softwares");

            migrationBuilder.AddColumn<string>(
                name: "SoftwareId",
                table: "Softwares",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_SoftwareId",
                table: "Softwares",
                column: "SoftwareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Softwares__GenericLists_SoftwareId",
                table: "Softwares",
                column: "SoftwareId",
                principalTable: "_GenericLists",
                principalColumn: "Id");
        }
    }
}
