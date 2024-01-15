using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class SoftwareMigLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "Position", "TerminationDate", "Text", "Type" },
                values: new object[,]
                {
                    { "SoftwareNameAdobeAcrobat", null, "SoftwareName", null, null, null, null, "Adobe Acrobat", 0 },
                    { "SoftwareNameAutocad", null, "SoftwareName", null, null, null, null, "Autocad", 0 },
                    { "SoftwareNameMicrosoft365", null, "SoftwareName", null, null, null, null, "Microsoft 365", 0 },
                    { "SoftwareNameSage", null, "SoftwareName", null, null, null, null, "Sage", 0 },
                    { "SoftwareNameTeamViewer", null, "SoftwareName", null, null, null, null, "TeamViewer", 0 },
                    { "SoftwareTypeDesign", null, "SoftwareType", null, null, null, null, "Diseño", 0 },
                    { "SoftwareTypeManagement", null, "SoftwareType", null, null, null, null, "Gestión", 0 },
                    { "SoftwareTypeOperativeSystem", null, "SoftwareType", null, null, null, null, "Sistema operativo", 0 },
                    { "SoftwareTypeSecurity", null, "SoftwareType", null, null, null, null, "Seguridad", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameAdobeAcrobat");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameAutocad");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameMicrosoft365");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameSage");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameTeamViewer");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeDesign");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeManagement");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeOperativeSystem");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeSecurity");
        }
    }
}
