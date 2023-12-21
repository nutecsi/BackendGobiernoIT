using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompanies2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[] { -1001, "onClick:splitScreenOverlay?CompaniesScreen", "*", null, "Companies" });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[] { "Companies", "new", "punta.png", "splitScreenOverlay?CompaniesScreen" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1001);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Companies");
        }
    }
}
