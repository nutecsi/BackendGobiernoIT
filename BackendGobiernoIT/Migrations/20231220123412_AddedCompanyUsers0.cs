using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompanyUsers0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntraIdUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntraIdPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRemoteAccess = table.Column<bool>(type: "bit", nullable: false),
                    WorkCenterId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyUsers_WorkCenters_WorkCenterId",
                        column: x => x.WorkCenterId,
                        principalTable: "WorkCenters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyUsers__GenericLists_Description",
                        column: x => x.Description,
                        principalTable: "_GenericLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailsInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyUserId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailsInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailsInfo_CompanyUsers_CompanyUserId",
                        column: x => x.CompanyUserId,
                        principalTable: "CompanyUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[,]
                {
                    { "CompanyUsers", "Create", null, "Delete", "Export", "CompanyUsers", "Read", "Update" },
                    { "EmailsInfo", "Create", null, "Delete", "Export", "EmailsInfo", "Read", "Update" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -1006, "onClick:splitScreenOverlay?EmailsInfoScreen", "*", null, "EmailsInfo" },
                    { -1005, "onClick:splitScreenOverlay?CompanyUsersScreen", "*", null, "CompanyUsers" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "CompanyUsers", "new", "punta.png", "splitScreenOverlay?CompanyUsersScreen" },
                    { "EmailsInfo", "new", "punta.png", "splitScreenOverlay?EmailsInfoScreen" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "Id", "CompanyUsers" },
                    { "Id", "EmailsInfo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_CompanyId",
                table: "CompanyUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_Description",
                table: "CompanyUsers",
                column: "Description");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_WorkCenterId",
                table: "CompanyUsers",
                column: "WorkCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailsInfo_CompanyUserId",
                table: "EmailsInfo",
                column: "CompanyUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailsInfo");

            migrationBuilder.DropTable(
                name: "CompanyUsers");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1006);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1005);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "CompanyUsers");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "EmailsInfo");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "CompanyUsers" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "EmailsInfo" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "CompanyUsers");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "EmailsInfo");
        }
    }
}
