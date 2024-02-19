using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedViewsToCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "View",
                table: "_TableData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "ActivityLog",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "BackupDeviceLinks",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Backups",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Cases",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Companies",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "CompanyManagers",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "CompanyUsers",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Connectors",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "DeviceLinks",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Devices",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Domains",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "EmailDomains",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "EmailsInfo",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "FileDescriptors",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Files",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "FollowUps",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "GenericLists",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Groups",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Hostings",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "HostingsInventory",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "NavbarNodes",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Phones",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Roles",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "SecurityRoles",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "SoftwareInventory",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Softwares",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "SSLCertificatesInventory",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "TableData",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "TableDataAlias",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "TableDataAttributes",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "TableDataButtons",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "TableDataPrimaryKeys",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Templates",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "UserRoles",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Users",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "UserTokens",
                column: "View",
                value: null);

            migrationBuilder.UpdateData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "WorkCenters",
                column: "View",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "View",
                table: "_TableData");
        }
    }
}
