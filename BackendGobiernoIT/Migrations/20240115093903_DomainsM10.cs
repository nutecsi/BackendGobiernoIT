using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class DomainsM10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Backups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    SoftwareItemId = table.Column<int>(type: "int", nullable: false),
                    SizeGB = table.Column<int>(type: "int", nullable: false),
                    InCloud = table.Column<bool>(type: "bit", nullable: false),
                    InLocal = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backups_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Backups_SoftwareInventory_SoftwareItemId",
                        column: x => x.SoftwareItemId,
                        principalTable: "SoftwareInventory",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[,]
                {
                    { "BackupDeviceLinks", "Create", null, "Delete", "Export", "BackupDeviceLinks", "Read", "Update" },
                    { "Backups", "Create", null, "Delete", "Export", "Backups", "Read", "Update" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -1019, "onClick:splitScreenOverlay?BackupDeviceLinksScreen", "*", null, "BackupDeviceLinks" },
                    { -1018, "onClick:splitScreenOverlay?BackupsScreen", "*", null, "Backups" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "BackupDeviceLinks", "new", "punta.png", "splitScreenOverlay?BackupDeviceLinksScreen" },
                    { "Backups", "new", "punta.png", "splitScreenOverlay?BackupsScreen" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "BackupId", "BackupDeviceLinks" },
                    { "DeviceId", "BackupDeviceLinks" },
                    { "Id", "Backups" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackupDeviceLinks_DeviceId",
                table: "BackupDeviceLinks",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Backups_CompanyId",
                table: "Backups",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Backups_SoftwareItemId",
                table: "Backups",
                column: "SoftwareItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackupDeviceLinks");

            migrationBuilder.DropTable(
                name: "Backups");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1019);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1018);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "BackupDeviceLinks");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Backups");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "BackupId", "BackupDeviceLinks" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "DeviceId", "BackupDeviceLinks" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "Backups" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "BackupDeviceLinks");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Backups");
        }
    }
}
