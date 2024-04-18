using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class TableConditionalFilters4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TableId",
                table: "_TableDataConditionalFilters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX__TableDataConditionalFilters_TableId",
                table: "_TableDataConditionalFilters",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK__TableDataConditionalFilters__TableData_TableId",
                table: "_TableDataConditionalFilters",
                column: "TableId",
                principalTable: "_TableData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__TableDataConditionalFilters__TableData_TableId",
                table: "_TableDataConditionalFilters");

            migrationBuilder.DropIndex(
                name: "IX__TableDataConditionalFilters_TableId",
                table: "_TableDataConditionalFilters");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "_TableDataConditionalFilters");
        }
    }
}
