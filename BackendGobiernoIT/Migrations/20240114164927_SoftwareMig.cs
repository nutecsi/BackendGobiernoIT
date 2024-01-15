using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class SoftwareMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInCloud",
                table: "Devices",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoftwareId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManufacturerId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Softwares__GenericLists_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Softwares__GenericLists_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Softwares__GenericLists_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SoftwareInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfLicences = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoftwareInventory_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SoftwareInventory_Softwares_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Softwares",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[,]
                {
                    { "SoftwareInventory", "Create", null, "Delete", "Export", "SoftwareInventory", "Read", "Update" },
                    { "Softwares", "Create", null, "Delete", "Export", "Softwares", "Read", "Update" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -1013, "onClick:splitScreenOverlay?SoftwareInventoryScreen", "*", null, "SoftwareInventory" },
                    { -1012, "onClick:splitScreenOverlay?SoftwaresScreen", "*", null, "Softwares" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "SoftwareInventory", "new", "punta.png", "splitScreenOverlay?SoftwareInventoryScreen" },
                    { "Softwares", "new", "punta.png", "splitScreenOverlay?SoftwaresScreen" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "Id", "SoftwareInventory" },
                    { "Id", "Softwares" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareInventory_CompanyId",
                table: "SoftwareInventory",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareInventory_SoftwareId",
                table: "SoftwareInventory",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_CategoryId",
                table: "Softwares",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_ManufacturerId",
                table: "Softwares",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_SoftwareId",
                table: "Softwares",
                column: "SoftwareId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoftwareInventory");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1013);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1012);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "SoftwareInventory");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Softwares");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "SoftwareInventory" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "Softwares" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "SoftwareInventory");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Softwares");

            migrationBuilder.DropColumn(
                name: "IsInCloud",
                table: "Devices");
        }
    }
}
