using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class DomainsM0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainExtensionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IncludesDNS = table.Column<bool>(type: "bit", nullable: false),
                    DnsProviderId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domains__GenericLists_DnsProviderId",
                        column: x => x.DnsProviderId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Domains__GenericLists_DomainExtensionId",
                        column: x => x.DomainExtensionId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Domains__GenericLists_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "Position", "TerminationDate", "Text", "Type" },
                values: new object[,]
                {
                    { "DnsExtensionCAT", null, "DnsExtension", null, null, null, null, ".cat", 0 },
                    { "DnsExtensionCOM", null, "DnsExtension", null, null, null, null, ".com", 0 },
                    { "DnsExtensionEDU", null, "DnsExtension", null, null, null, null, ".edu", 0 },
                    { "DnsExtensionES", null, "DnsExtension", null, null, null, null, ".es", 0 },
                    { "DnsExtensionINFO", null, "DnsExtension", null, null, null, null, ".info", 0 }
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[] { "Domains", "Create", null, "Delete", "Export", "Domains", "Read", "Update" });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[] { -1014, "onClick:splitScreenOverlay?DomainsScreen", "*", null, "Domains" });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[] { "Domains", "new", "punta.png", "splitScreenOverlay?DomainsScreen" });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[] { "Id", "Domains" });

            migrationBuilder.CreateIndex(
                name: "IX_Domains_DnsProviderId",
                table: "Domains",
                column: "DnsProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_DomainExtensionId",
                table: "Domains",
                column: "DomainExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_ProviderId",
                table: "Domains",
                column: "ProviderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionCAT");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionCOM");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionEDU");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionES");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionINFO");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1014);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Domains");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "Domains" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Domains");
        }
    }
}
