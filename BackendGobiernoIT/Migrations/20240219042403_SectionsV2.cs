using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class SectionsV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_Sections",
                column: "Name",
                values: new object[]
                {
                    "RequirementsToSectionsTable",
                    "SectionsToRequirementsTable"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_Sections",
                keyColumn: "Name",
                keyValue: "RequirementsToSectionsTable");

            migrationBuilder.DeleteData(
                table: "_Sections",
                keyColumn: "Name",
                keyValue: "SectionsToRequirementsTable");
        }
    }
}
