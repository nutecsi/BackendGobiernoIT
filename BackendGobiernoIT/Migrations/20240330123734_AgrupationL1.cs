using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AgrupationL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "NumLibre1", "Position", "TerminationDate", "Text", "TxtLibre1", "Type" },
                values: new object[] { "AgrupationL1", null, "NavbarNodeType", null, null, null, null, null, "AgrupationL1", null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "AgrupationL1");
        }
    }
}
