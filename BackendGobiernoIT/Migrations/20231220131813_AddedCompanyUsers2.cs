using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompanyUsers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUsers__GenericLists_Description",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_Description",
                table: "CompanyUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "CompanyUsers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_Department",
                table: "CompanyUsers",
                column: "Department");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUsers__GenericLists_Department",
                table: "CompanyUsers",
                column: "Department",
                principalTable: "_GenericLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUsers__GenericLists_Department",
                table: "CompanyUsers");

            migrationBuilder.DropIndex(
                name: "IX_CompanyUsers_Department",
                table: "CompanyUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CompanyUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "CompanyUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_Description",
                table: "CompanyUsers",
                column: "Description");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUsers__GenericLists_Description",
                table: "CompanyUsers",
                column: "Description",
                principalTable: "_GenericLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
