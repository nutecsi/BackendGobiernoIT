using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompanies3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -1004, "onClick:splitScreenOverlay?WorkCentersScreen", "*", null, "WorkCenters" },
                    { -1003, "onClick:splitScreenOverlay?PhonesScreen", "*", null, "Phones" },
                    { -1002, "onClick:splitScreenOverlay?EmailDomainsScreen", "*", null, "EmailDomains" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "EmailDomains", "new", "punta.png", "splitScreenOverlay?EmailDomainsScreen" },
                    { "Phones", "new", "punta.png", "splitScreenOverlay?PhonesScreen" },
                    { "WorkCenters", "new", "punta.png", "splitScreenOverlay?WorkCentersScreen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1004);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1003);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1002);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "EmailDomains");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Phones");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "WorkCenters");
        }
    }
}
