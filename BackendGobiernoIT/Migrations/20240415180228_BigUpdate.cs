using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class BigUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackupDeviceLinks");

            migrationBuilder.AddColumn<string>(
                name: "ProviderId",
                table: "SoftwareInventory",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeactivationDate",
                table: "Hostings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderId",
                table: "Domains",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "RegistradorId",
                table: "Domains",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeactivationDate",
                table: "Devices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeactivationDate",
                table: "CompanyUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasItSupport",
                table: "Companies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TypeId",
                table: "Companies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "CompanyTypeClient");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeactivationDate",
                table: "Backups",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Backups",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "NumLibre1", "Position", "TerminationDate", "Text", "TxtLibre1", "Type" },
                values: new object[,]
                {
                    { "CompanyTypeClient", null, "CompanyType", null, null, null, null, null, "Cliente", null, 0 },
                    { "CompanyTypeClientAndSupplier", null, "CompanyType", null, null, null, null, null, "Cliente y Proveedor", null, 0 },
                    { "CompanyTypeSupplier", null, "CompanyType", null, null, null, null, null, "Proveedor", null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareInventory_ProviderId",
                table: "SoftwareInventory",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_RegistradorId",
                table: "Domains",
                column: "RegistradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TypeId",
                table: "Companies",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Backups_DeviceId",
                table: "Backups",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backups_Devices_DeviceId",
                table: "Backups",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies__GenericLists_TypeId",
                table: "Companies",
                column: "TypeId",
                principalTable: "_GenericLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Domains__GenericLists_RegistradorId",
                table: "Domains",
                column: "RegistradorId",
                principalTable: "_GenericLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftwareInventory__GenericLists_ProviderId",
                table: "SoftwareInventory",
                column: "ProviderId",
                principalTable: "_GenericLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backups_Devices_DeviceId",
                table: "Backups");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies__GenericLists_TypeId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Domains__GenericLists_RegistradorId",
                table: "Domains");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareInventory__GenericLists_ProviderId",
                table: "SoftwareInventory");

            migrationBuilder.DropIndex(
                name: "IX_SoftwareInventory_ProviderId",
                table: "SoftwareInventory");

            migrationBuilder.DropIndex(
                name: "IX_Domains_RegistradorId",
                table: "Domains");

            migrationBuilder.DropIndex(
                name: "IX_Companies_TypeId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Backups_DeviceId",
                table: "Backups");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CompanyTypeClient");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CompanyTypeClientAndSupplier");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CompanyTypeSupplier");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "SoftwareInventory");

            migrationBuilder.DropColumn(
                name: "DeactivationDate",
                table: "Hostings");

            migrationBuilder.DropColumn(
                name: "RegistradorId",
                table: "Domains");

            migrationBuilder.DropColumn(
                name: "DeactivationDate",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "DeactivationDate",
                table: "CompanyUsers");

            migrationBuilder.DropColumn(
                name: "HasItSupport",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DeactivationDate",
                table: "Backups");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Backups");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderId",
                table: "Domains",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BackupDeviceLinks",
                columns: table => new
                {
                    BackupId = table.Column<int>(type: "int", nullable: false),
                    DeviceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackupDeviceLinks", x => new { x.BackupId, x.DeviceId });
                    table.ForeignKey(
                        name: "FK_BackupDeviceLinks_Backups_BackupId",
                        column: x => x.BackupId,
                        principalTable: "Backups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackupDeviceLinks_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackupDeviceLinks_DeviceId",
                table: "BackupDeviceLinks",
                column: "DeviceId");
        }
    }
}
