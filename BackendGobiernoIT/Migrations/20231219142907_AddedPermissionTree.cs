using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedPermissionTree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_PermissionTree",
                columns: new[] { "Id", "ParentId", "Permission", "Text" },
                values: new object[,]
                {
                    { -1, null, null, "VirtualTables" },
                    { -2, -1, null, "Generics" },
                    { -7, -2, "Export", "Export" },
                    { -6, -2, "Delete", "Delete" },
                    { -5, -2, "Update", "Update" },
                    { -4, -2, "Read", "Read" },
                    { -3, -2, "Create", "Create" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_PermissionTree",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "_PermissionTree",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "_PermissionTree",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "_PermissionTree",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "_PermissionTree",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "_PermissionTree",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "_PermissionTree",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
