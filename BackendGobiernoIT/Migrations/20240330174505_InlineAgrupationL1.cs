using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class InlineAgrupationL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "NumLibre1", "Position", "TerminationDate", "Text", "TxtLibre1", "Type" },
                values: new object[] { "InlineAgrupationL1", null, "NavbarNodeType", null, null, null, null, null, "InlineAgrupationL1", null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "InlineAgrupationL1");
        }
    }
}
