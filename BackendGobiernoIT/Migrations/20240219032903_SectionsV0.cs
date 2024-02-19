using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class SectionsV0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SectionId",
                table: "_TableDataViews",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "ApplicationTable");

            migrationBuilder.InsertData(
                table: "_Sections",
                column: "Name",
                value: "ApplicationTable");

            migrationBuilder.CreateIndex(
                name: "IX__TableDataViews_SectionId",
                table: "_TableDataViews",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK__TableDataViews__Sections_SectionId",
                table: "_TableDataViews",
                column: "SectionId",
                principalTable: "_Sections",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__TableDataViews__Sections_SectionId",
                table: "_TableDataViews");

            migrationBuilder.DropIndex(
                name: "IX__TableDataViews_SectionId",
                table: "_TableDataViews");

            migrationBuilder.DeleteData(
                table: "_Sections",
                keyColumn: "Name",
                keyValue: "ApplicationTable");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "_TableDataViews");
        }
    }
}
