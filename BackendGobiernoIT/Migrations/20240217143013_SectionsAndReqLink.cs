using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class SectionsAndReqLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Sections__RequirementDefinitions_RequirementDefinitionName",
                table: "_Sections");

            migrationBuilder.DropIndex(
                name: "IX__Sections_RequirementDefinitionName",
                table: "_Sections");

            migrationBuilder.DropColumn(
                name: "RequirementDefinitionName",
                table: "_Sections");

            migrationBuilder.CreateTable(
                name: "_RequirementDefinitionSectionLinks",
                columns: table => new
                {
                    RequirementDefinitionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SectionId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RequirementDefinitionSectionLinks", x => new { x.RequirementDefinitionId, x.SectionId });
                    table.ForeignKey(
                        name: "FK__RequirementDefinitionSectionLinks__RequirementDefinitions_RequirementDefinitionId",
                        column: x => x.RequirementDefinitionId,
                        principalTable: "_RequirementDefinitions",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__RequirementDefinitionSectionLinks__Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "_Sections",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update", "View" },
                values: new object[] { "RequirementDefinitionSectionLinks", "Create", null, "Delete", "Export", "_RequirementDefinitionSectionLinks", "Read", "Update", null });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "RequirementDefinitionId", "RequirementDefinitionSectionLinks" },
                    { "SectionId", "RequirementDefinitionSectionLinks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX__RequirementDefinitionSectionLinks_SectionId",
                table: "_RequirementDefinitionSectionLinks",
                column: "SectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_RequirementDefinitionSectionLinks");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "RequirementDefinitionId", "RequirementDefinitionSectionLinks" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "SectionId", "RequirementDefinitionSectionLinks" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "RequirementDefinitionSectionLinks");

            migrationBuilder.AddColumn<string>(
                name: "RequirementDefinitionName",
                table: "_Sections",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX__Sections_RequirementDefinitionName",
                table: "_Sections",
                column: "RequirementDefinitionName");

            migrationBuilder.AddForeignKey(
                name: "FK__Sections__RequirementDefinitions_RequirementDefinitionName",
                table: "_Sections",
                column: "RequirementDefinitionName",
                principalTable: "_RequirementDefinitions",
                principalColumn: "Name");
        }
    }
}
