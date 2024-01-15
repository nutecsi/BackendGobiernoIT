using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class DomainsM2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hostings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagementURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HostingSystemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RenovationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hostings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hostings__GenericLists_HostingSystemId",
                        column: x => x.HostingSystemId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hostings__GenericLists_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SSLCertificatesInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RenovationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSLCertificatesInventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HostingsInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    HostingId = table.Column<int>(type: "int", nullable: false),
                    Redirect301 = table.Column<bool>(type: "bit", nullable: false),
                    IncludesSSL = table.Column<bool>(type: "bit", nullable: false),
                    SSLCertId = table.Column<int>(type: "int", nullable: true),
                    DnsServicesActive = table.Column<bool>(type: "bit", nullable: false),
                    MailServicesActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostingsInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostingsInventory_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HostingsInventory_Hostings_HostingId",
                        column: x => x.HostingId,
                        principalTable: "Hostings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HostingsInventory_SSLCertificatesInventory_SSLCertId",
                        column: x => x.SSLCertId,
                        principalTable: "SSLCertificatesInventory",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[,]
                {
                    { "Hostings", "Create", null, "Delete", "Export", "Domains", "Read", "Update" },
                    { "HostingsInventory", "Create", null, "Delete", "Export", "Domains", "Read", "Update" },
                    { "SSLCertificatesInventory", "Create", null, "Delete", "Export", "Domains", "Read", "Update" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -1017, "onClick:splitScreenOverlay?HostingsInventoryScreen", "*", null, "HostingsInventory" },
                    { -1016, "onClick:splitScreenOverlay?HostingsScreen", "*", null, "Hostings" },
                    { -1015, "onClick:splitScreenOverlay?SSLCertificatesInventoryScreen", "*", null, "SSLCertificatesInventory" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "Hostings", "new", "punta.png", "splitScreenOverlay?DomainsScreen" },
                    { "HostingsInventory", "new", "punta.png", "splitScreenOverlay?DomainsScreen" },
                    { "SSLCertificatesInventory", "new", "punta.png", "splitScreenOverlay?DomainsScreen" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "Id", "Hostings" },
                    { "Id", "HostingsInventory" },
                    { "Id", "SSLCertificatesInventory" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hostings_HostingSystemId",
                table: "Hostings",
                column: "HostingSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Hostings_ProviderId",
                table: "Hostings",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_HostingsInventory_CompanyId",
                table: "HostingsInventory",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_HostingsInventory_HostingId",
                table: "HostingsInventory",
                column: "HostingId");

            migrationBuilder.CreateIndex(
                name: "IX_HostingsInventory_SSLCertId",
                table: "HostingsInventory",
                column: "SSLCertId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HostingsInventory");

            migrationBuilder.DropTable(
                name: "Hostings");

            migrationBuilder.DropTable(
                name: "SSLCertificatesInventory");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1017);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1016);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1015);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Hostings");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "HostingsInventory");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "SSLCertificatesInventory");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "Hostings" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "HostingsInventory" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "SSLCertificatesInventory" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Hostings");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "HostingsInventory");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "SSLCertificatesInventory");
        }
    }
}
