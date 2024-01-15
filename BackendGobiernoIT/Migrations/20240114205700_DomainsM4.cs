using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class DomainsM4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CertTypeId",
                table: "SSLCertificatesInventory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Hostings",
                column: "Name",
                value: "Hostings");

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "HostingsInventory",
                column: "Name",
                value: "HostingsInventory");

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "SSLCertificatesInventory",
                column: "Name",
                value: "SSLCertificatesInventory");

            migrationBuilder.CreateIndex(
                name: "IX_SSLCertificatesInventory_CertTypeId",
                table: "SSLCertificatesInventory",
                column: "CertTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SSLCertificatesInventory__GenericLists_CertTypeId",
                table: "SSLCertificatesInventory",
                column: "CertTypeId",
                principalTable: "_GenericLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SSLCertificatesInventory__GenericLists_CertTypeId",
                table: "SSLCertificatesInventory");

            migrationBuilder.DropIndex(
                name: "IX_SSLCertificatesInventory_CertTypeId",
                table: "SSLCertificatesInventory");

            migrationBuilder.AlterColumn<string>(
                name: "CertTypeId",
                table: "SSLCertificatesInventory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Hostings",
                column: "Name",
                value: "Domains");

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "HostingsInventory",
                column: "Name",
                value: "Domains");

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "SSLCertificatesInventory",
                column: "Name",
                value: "Domains");
        }
    }
}
