using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedDependencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseDependencies",
                columns: table => new
                {
                    SourceId = table.Column<int>(type: "int", nullable: false),
                    DependsOnId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseDependencies", x => new { x.SourceId, x.DependsOnId });
                    table.ForeignKey(
                        name: "FK_CaseDependencies_Cases_DependsOnId",
                        column: x => x.DependsOnId,
                        principalTable: "Cases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaseDependencies_Cases_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Cases",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update", "View" },
                values: new object[] { "CaseDependencies", "Create", null, "Delete", "Export", "CaseDependencies", "Read", "Update", null });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[] { -1020, "onClick:splitScreenOverlay?CasesScreenForDeps", "*", null, "CaseDependencies" });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[] { "CaseDependencies", "new", "punta.png", "splitScreenOverlay?CaseDependenciesScreen" });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "DependsOnId", "CaseDependencies" },
                    { "SourceId", "CaseDependencies" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseDependencies_DependsOnId",
                table: "CaseDependencies",
                column: "DependsOnId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseDependencies");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1020);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "CaseDependencies");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "DependsOnId", "CaseDependencies" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "SourceId", "CaseDependencies" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "CaseDependencies");
        }
    }
}
