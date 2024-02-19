using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class RemovedUsersConfigOld : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_TableDataUsersConfig");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_TableDataUsersConfig",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ViewName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColumnOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplexFilters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilterOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    SortOptions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataUsersConfig", x => new { x.UserId, x.TableId, x.ViewName });
                    table.ForeignKey(
                        name: "FK__TableDataUsersConfig__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__TableDataUsersConfig___AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__TableDataUsersConfig_TableId",
                table: "_TableDataUsersConfig",
                column: "TableId");
        }
    }
}
