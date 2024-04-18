using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class TableConditionalFilters2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update", "View" },
                values: new object[] { "TableDataConditionalFilters", "Create", null, "Delete", "Export", "_TableDataConditionalFilters", "Read", "Update", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "TableDataConditionalFilters");
        }
    }
}
