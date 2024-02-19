using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class SectionsAndReq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_RequirementDefinitions",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequirementGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeactivationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HelpHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRequiredDocumentDate = table.Column<bool>(type: "bit", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Expires = table.Column<bool>(type: "bit", nullable: false),
                    ExpirationPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RequirementDefinitions", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "_Requirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementDefinitionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    DocumentGroupId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DocumentUploaderUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentUploadDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Requirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Requirements__Groups_DocumentGroupId",
                        column: x => x.DocumentGroupId,
                        principalTable: "_Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Requirements__Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "_Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Requirements__RequirementDefinitions_RequirementDefinitionId",
                        column: x => x.RequirementDefinitionId,
                        principalTable: "_RequirementDefinitions",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_Sections",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequirementDefinitionName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sections", x => x.Name);
                    table.ForeignKey(
                        name: "FK__Sections__RequirementDefinitions_RequirementDefinitionName",
                        column: x => x.RequirementDefinitionName,
                        principalTable: "_RequirementDefinitions",
                        principalColumn: "Name");
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update", "View" },
                values: new object[,]
                {
                    { "RequirementDefinitions", "Create", null, "Delete", "Export", "_RequirementDefinitions", "Read", "Update", null },
                    { "Requirements", "Create", null, "Delete", "Export", "_Requirements", "Read", "Update", null },
                    { "Sections", "Create", null, "Delete", "Export", "_Sections", "Read", "Update", null }
                });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -10, "onClick:splitScreenOverlay?SectionsScreen", "*", null, "Sections" },
                    { -9, "onClick:splitScreenOverlay?RequirementDefinitionsScreen", "*", null, "RequirementDefinitions" },
                    { -8, "onClick:splitScreenOverlay?RequirementsScreen", "*", null, "Requirements" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "RequirementDefinitions", "new", "punta.png", "splitScreenOverlay?RequirementDefinitionsScreen" },
                    { "Requirements", "new", "punta.png", "splitScreenOverlay?RequirementsScreen" },
                    { "Sections", "new", "punta.png", "splitScreenOverlay?SectionsScreen" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "Name", "RequirementDefinitions" },
                    { "Id", "Requirements" },
                    { "Name", "Sections" }
                });

            migrationBuilder.CreateIndex(
                name: "IX__Requirements_DocumentGroupId",
                table: "_Requirements",
                column: "DocumentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX__Requirements_GroupId",
                table: "_Requirements",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX__Requirements_RequirementDefinitionId",
                table: "_Requirements",
                column: "RequirementDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX__Sections_RequirementDefinitionName",
                table: "_Sections",
                column: "RequirementDefinitionName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Requirements");

            migrationBuilder.DropTable(
                name: "_Sections");

            migrationBuilder.DropTable(
                name: "_RequirementDefinitions");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "RequirementDefinitions");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Requirements");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Sections");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Name", "RequirementDefinitions" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "Requirements" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Name", "Sections" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "RequirementDefinitions");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Requirements");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Sections");
        }
    }
}
