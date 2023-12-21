using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedDevices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "EmailsInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManufacturerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManufacturerSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsInMaintenance = table.Column<bool>(type: "bit", nullable: false),
                    WorkCenterId = table.Column<int>(type: "int", nullable: false),
                    OperatingSystemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InternalIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalIPMaskId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InternalPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalIPMaskId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExternalPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RAMId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeHD1Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeHD2Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HD3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeHD3Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SupplierId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AcquisitionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarrantyExpiration = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devices_WorkCenters_WorkCenterId",
                        column: x => x.WorkCenterId,
                        principalTable: "WorkCenters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_ExternalIPMaskId",
                        column: x => x.ExternalIPMaskId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_InternalIPMaskId",
                        column: x => x.InternalIPMaskId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_OperatingSystemId",
                        column: x => x.OperatingSystemId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_RAMId",
                        column: x => x.RAMId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_TypeHD1Id",
                        column: x => x.TypeHD1Id,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_TypeHD2Id",
                        column: x => x.TypeHD2Id,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Devices__GenericLists_TypeHD3Id",
                        column: x => x.TypeHD3Id,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "Position", "TerminationDate", "Text", "Type" },
                values: new object[,]
                {
                    { "DeviceTypeNAS", null, "DeviceType", null, null, null, null, "NAS", 0 },
                    { "DeviceTypeOrdenador", null, "DeviceType", null, null, null, null, "Ordenador", 0 },
                    { "DeviceTypePortatil", null, "DeviceType", null, null, null, null, "Portatil", 0 },
                    { "HardDriveTypeNVMe", null, "HardDriveType", null, null, null, null, "NVMe", 0 },
                    { "HardDriveTypeSSD", null, "HardDriveType", null, null, null, null, "SSD", 0 },
                    { "IPMask16", null, "IPMask", null, null, null, null, "16", 0 },
                    { "IPMask24", null, "IPMask", null, null, null, null, "24", 0 },
                    { "IPMask28", null, "IPMask", null, null, null, null, "28", 0 },
                    { "IPMask32", null, "IPMask", null, null, null, null, "32", 0 },
                    { "IPMask8", null, "IPMask", null, null, null, null, "8", 0 },
                    { "ManufacturerHP", null, "Manufacturer", null, null, null, null, "HP", 0 },
                    { "ManufacturerMicrosoft", null, "Manufacturer", null, null, null, null, "Microsoft", 0 },
                    { "OperatingSystemAndroid", null, "OperatingSystem", null, null, null, null, "Android", 0 },
                    { "OperatingSystemIOS", null, "OperatingSystem", null, null, null, null, "iOS", 0 },
                    { "OperatingSystemLinux", null, "OperatingSystem", null, null, null, null, "Linux", 0 },
                    { "OperatingSystemMacOS", null, "OperatingSystem", null, null, null, null, "macOS", 0 },
                    { "OperatingSystemUbuntu", null, "OperatingSystem", null, null, null, null, "Ubuntu", 0 },
                    { "OperatingSystemWindows10", null, "OperatingSystem", null, null, null, null, "Windows 10", 0 },
                    { "OperatingSystemWindows7", null, "OperatingSystem", null, null, null, null, "Windows 7", 0 },
                    { "OperatingSystemWindowsServer2019", null, "OperatingSystem", null, null, null, null, "Windows Server 2019", 0 },
                    { "ProcessorARMv7", null, "Processor", null, null, null, null, "ARMv7", 0 },
                    { "ProcessorARMv8", null, "Processor", null, null, null, null, "ARMv8", 0 },
                    { "ProcessorARMv8_2", null, "Processor", null, null, null, null, "ARMv8.2", 0 },
                    { "ProcessorARMv9", null, "Processor", null, null, null, null, "ARMv9", 0 },
                    { "ProcessorIntelI5", null, "Processor", null, null, null, null, "Intel i5", 0 },
                    { "ProcessorXeon", null, "Processor", null, null, null, null, "Xeon", 0 },
                    { "RAM128GB", null, "RAM", null, null, null, null, "128 GB", 0 },
                    { "RAM16GB", null, "RAM", null, null, null, null, "16 GB", 0 },
                    { "RAM1TB", null, "RAM", null, null, null, null, "1 TB", 0 },
                    { "RAM256GB", null, "RAM", null, null, null, null, "256 GB", 0 },
                    { "RAM2GB", null, "RAM", null, null, null, null, "2 GB", 0 },
                    { "RAM32GB", null, "RAM", null, null, null, null, "32 GB", 0 },
                    { "RAM4GB", null, "RAM", null, null, null, null, "4 GB", 0 },
                    { "RAM512GB", null, "RAM", null, null, null, null, "512 GB", 0 },
                    { "RAM64GB", null, "RAM", null, null, null, null, "64 GB", 0 },
                    { "RAM8GB", null, "RAM", null, null, null, null, "8 GB", 0 },
                    { "SupplierNutec", null, "Supplier", null, null, null, null, "Nutec", 0 }
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[] { "Devices", "Create", null, "Delete", "Export", "Devices", "Read", "Update" });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[] { -1007, "onClick:splitScreenOverlay?DevicesScreen", "*", null, "Devices" });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[] { "Devices", "new", "punta.png", "splitScreenOverlay?DevicesScreen" });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[] { "Id", "Devices" });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_CompanyId",
                table: "Devices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceTypeId",
                table: "Devices",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ExternalIPMaskId",
                table: "Devices",
                column: "ExternalIPMaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_InternalIPMaskId",
                table: "Devices",
                column: "InternalIPMaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ManufacturerId",
                table: "Devices",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_OperatingSystemId",
                table: "Devices",
                column: "OperatingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ProcessorId",
                table: "Devices",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_RAMId",
                table: "Devices",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_SupplierId",
                table: "Devices",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_TypeHD1Id",
                table: "Devices",
                column: "TypeHD1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_TypeHD2Id",
                table: "Devices",
                column: "TypeHD2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_TypeHD3Id",
                table: "Devices",
                column: "TypeHD3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_WorkCenterId",
                table: "Devices",
                column: "WorkCenterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DeviceTypeNAS");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DeviceTypeOrdenador");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DeviceTypePortatil");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "HardDriveTypeNVMe");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "HardDriveTypeSSD");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask16");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask24");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask28");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask32");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask8");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ManufacturerHP");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ManufacturerMicrosoft");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemAndroid");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemIOS");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemLinux");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemMacOS");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemUbuntu");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemWindows10");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemWindows7");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemWindowsServer2019");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv7");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv8");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv8_2");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv9");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorIntelI5");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorXeon");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM128GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM16GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM1TB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM256GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM2GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM32GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM4GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM512GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM64GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM8GB");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SupplierNutec");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1007);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Devices");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "Devices" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Devices");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "EmailsInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
