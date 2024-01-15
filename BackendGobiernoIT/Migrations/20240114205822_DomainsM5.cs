using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class DomainsM5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Hostings",
                column: "OnClick",
                value: "splitScreenOverlay?HostingsScreen");

            migrationBuilder.UpdateData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "HostingsInventory",
                column: "OnClick",
                value: "splitScreenOverlay?HostingsInventoryScreen");

            migrationBuilder.UpdateData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "SSLCertificatesInventory",
                column: "OnClick",
                value: "splitScreenOverlay?SSLCertificatesInventoryScreen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Hostings",
                column: "OnClick",
                value: "splitScreenOverlay?DomainsScreen");

            migrationBuilder.UpdateData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "HostingsInventory",
                column: "OnClick",
                value: "splitScreenOverlay?DomainsScreen");

            migrationBuilder.UpdateData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "SSLCertificatesInventory",
                column: "OnClick",
                value: "splitScreenOverlay?DomainsScreen");
        }
    }
}
