using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class TableConditionalFilters3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -12, "onClick:splitScreenOverlay?TableDataConditionalFiltersScreen", "*", null, "TableDataConditionalFilters" },
                    { -11, "onClick:splitScreenOverlay?TableDataScreen", "*", null, "TableData" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[] { "TableDataConditionalFilters", "new", "plus", "splitScreenOverlay?TableDataConditionalFiltersScreen" });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[] { "Id", "TableDataConditionalFilters" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "TableDataConditionalFilters");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "TableDataConditionalFilters" });
        }
    }
}
