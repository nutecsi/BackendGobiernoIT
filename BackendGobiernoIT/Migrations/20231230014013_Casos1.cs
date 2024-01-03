using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class Casos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatorUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequesterClientId = table.Column<int>(type: "int", nullable: false),
                    ResponsibleUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HardwareInventoryId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosureDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosingUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StatusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PriorityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassificationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntryChannelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    CaseDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    DependantTaskId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cases_Cases_DependantTaskId",
                        column: x => x.DependantTaskId,
                        principalTable: "Cases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_Cases_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Cases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_CompanyUsers_RequesterClientId",
                        column: x => x.RequesterClientId,
                        principalTable: "CompanyUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases_Devices_HardwareInventoryId",
                        column: x => x.HardwareInventoryId,
                        principalTable: "Devices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases__GenericLists_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases__GenericLists_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases__GenericLists_EntryChannelId",
                        column: x => x.EntryChannelId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases__GenericLists_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases__GenericLists_StatusId",
                        column: x => x.StatusId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases__Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "_Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases___AspNetUsers_ClosingUserId",
                        column: x => x.ClosingUserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases___AspNetUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cases___AspNetUsers_ResponsibleUserId",
                        column: x => x.ResponsibleUserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FollowUps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    InternalUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientUserId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    NotifyByEmail = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FollowUps_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowUps_CompanyUsers_ClientUserId",
                        column: x => x.ClientUserId,
                        principalTable: "CompanyUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FollowUps___AspNetUsers_InternalUserId",
                        column: x => x.InternalUserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[,]
                {
                    { "Cases", "Create", null, "Delete", "Export", "Cases", "Read", "Update" },
                    { "FollowUps", "Create", null, "Delete", "Export", "FollowUps", "Read", "Update" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -1009, "onClick:splitScreenOverlay?CasesScreen", "*", null, "Cases" },
                    { -1008, "onClick:splitScreenOverlay?FollowUpsScreen", "*", null, "FollowUps" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "Cases", "new", "punta.png", "splitScreenOverlay?CasesScreen" },
                    { "FollowUps", "new", "punta.png", "splitScreenOverlay?FollowUpsScreen" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "Id", "Cases" },
                    { "Id", "FollowUps" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CategoryId",
                table: "Cases",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ClassificationId",
                table: "Cases",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ClosingUserId",
                table: "Cases",
                column: "ClosingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CompanyId",
                table: "Cases",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CreatorUserId",
                table: "Cases",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_DependantTaskId",
                table: "Cases",
                column: "DependantTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_EntryChannelId",
                table: "Cases",
                column: "EntryChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_GroupId",
                table: "Cases",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_HardwareInventoryId",
                table: "Cases",
                column: "HardwareInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ParentId",
                table: "Cases",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_PriorityId",
                table: "Cases",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_RequesterClientId",
                table: "Cases",
                column: "RequesterClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_ResponsibleUserId",
                table: "Cases",
                column: "ResponsibleUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_StatusId",
                table: "Cases",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUps_CaseId",
                table: "FollowUps",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUps_ClientUserId",
                table: "FollowUps",
                column: "ClientUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUps_InternalUserId",
                table: "FollowUps",
                column: "InternalUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowUps");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1009);

            migrationBuilder.DeleteData(
                table: "_TableDataAttributes",
                keyColumn: "Id",
                keyValue: -1008);

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "Cases");

            migrationBuilder.DeleteData(
                table: "_TableDataButtons",
                keyColumn: "TableId",
                keyValue: "FollowUps");

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "Cases" });

            migrationBuilder.DeleteData(
                table: "_TableDataPrimaryKeys",
                keyColumns: new[] { "ColumnName", "TableId" },
                keyValues: new object[] { "Id", "FollowUps" });

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "Cases");

            migrationBuilder.DeleteData(
                table: "_TableData",
                keyColumn: "Id",
                keyValue: "FollowUps");
        }
    }
}
