using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "SoftwareInventory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "SoftwareInventory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MainUserId",
                table: "Devices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "External",
                table: "CompanyUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<int>(
                name: "CompanyUserId",
                table: "Cases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SSLCertificatesInventory_GroupId",
                table: "SSLCertificatesInventory",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareInventory_GroupId",
                table: "SoftwareInventory",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_MainUserId",
                table: "Devices",
                column: "MainUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_MainUserId1",
                table: "CompanyUsers",
                column: "MainUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CompanyUserId",
                table: "Cases",
                column: "CompanyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_CompanyUsers_CompanyUserId",
                table: "Cases",
                column: "CompanyUserId",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUsers_CompanyUsers_MainUserId1",
                table: "CompanyUsers",
                column: "MainUserId1",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_CompanyUsers_MainUserId",
                table: "Devices",
                column: "MainUserId",
                principalTable: "CompanyUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftwareInventory__Groups_GroupId",
                table: "SoftwareInventory",
                column: "GroupId",
                principalTable: "_Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SSLCertificatesInventory__Groups_GroupId",
                table: "SSLCertificatesInventory",
                column: "GroupId",
                principalTable: "_Groups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_CompanyUsers_CompanyUserId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUsers_CompanyUsers_MainUserId1",
                table: "CompanyUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_CompanyUsers_MainUserId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareInventory__Groups_GroupId",
                table: "SoftwareInventory");

            migrationBuilder.DropForeignKey(
                name: "FK_SSLCertificatesInventory__Groups_GroupId",
                table: "SSLCertificatesInventory");

            migrationBuilder.DropIndex(
                name: "IX_SSLCertificatesInventory_GroupId",
                table: "SSLCertificatesInventory");

            migrationBuilder.DropIndex(
                name: "IX_SoftwareInventory_GroupId",
                table: "SoftwareInventory");

            migrationBuilder.DropIndex(
                name: "IX_Devices_MainUserId",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_MainUserId1",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_Cases_CompanyUserId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "SoftwareInventory");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "SoftwareInventory");

            migrationBuilder.DropColumn(
                name: "MainUserId",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "External",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "MainUserId",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "MainUserId1",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "CompanyUserId",
                table: "Cases");
        }
    }
}
