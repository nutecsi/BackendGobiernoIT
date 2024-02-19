using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class CambioEnInvSoftware2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backups_SoftwareInventory_SoftwareItemId",
                table: "Backups");

            migrationBuilder.RenameColumn(
                name: "SoftwareItemId",
                table: "Backups",
                newName: "SoftwareId");

            migrationBuilder.RenameIndex(
                name: "IX_Backups_SoftwareItemId",
                table: "Backups",
                newName: "IX_Backups_SoftwareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backups_Softwares_SoftwareId",
                table: "Backups",
                column: "SoftwareId",
                principalTable: "Softwares",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backups_Softwares_SoftwareId",
                table: "Backups");

            migrationBuilder.RenameColumn(
                name: "SoftwareId",
                table: "Backups",
                newName: "SoftwareItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Backups_SoftwareId",
                table: "Backups",
                newName: "IX_Backups_SoftwareItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backups_SoftwareInventory_SoftwareItemId",
                table: "Backups",
                column: "SoftwareItemId",
                principalTable: "SoftwareInventory",
                principalColumn: "Id");
        }
    }
}
