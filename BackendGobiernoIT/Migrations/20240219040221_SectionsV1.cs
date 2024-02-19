using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class SectionsV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__TableDataViews",
                table: "_TableDataViews");

            migrationBuilder.AddPrimaryKey(
                name: "PK__TableDataViews",
                table: "_TableDataViews",
                columns: new[] { "UserId", "TableId", "Name", "SectionId" });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update", "View" },
                values: new object[] { "TableDataViews", "Create", null, "Delete", "Export", "_TableDataViews", "Read", "Update", null });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "Name", "TableDataViews" },
                    { "SectionId", "TableDataViews" },
                    { "TableId", "TableDataViews" },
                    { "UserId", "TableDataViews" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__TableDataViews",
                table: "_TableDataViews");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Name", "TableDataViews" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "SectionId", "TableDataViews" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "TableId", "TableDataViews" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "UserId", "TableDataViews" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "TableDataViews");

            migrationBuilder.AddPrimaryKey(
                name: "PK__TableDataViews",
                table: "_TableDataViews",
                columns: new[] { "UserId", "TableId", "Name" });
        }
    }
}
