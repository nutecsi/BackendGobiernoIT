using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompanyUsers1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "Position", "TerminationDate", "Text", "Type" },
                values: new object[,]
                {
                    { "DepartmentsCompras", null, "Departments", null, null, null, null, "Compras", 0 },
                    { "DepartmentsContabilidad", null, "Departments", null, null, null, null, "Contabilidad", 0 },
                    { "DepartmentsDireccion", null, "Departments", null, null, null, null, "Direccion", 0 },
                    { "DepartmentsRRHH", null, "Departments", null, null, null, null, "RRHH", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsCompras");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsContabilidad");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsDireccion");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsRRHH");
        }
    }
}
