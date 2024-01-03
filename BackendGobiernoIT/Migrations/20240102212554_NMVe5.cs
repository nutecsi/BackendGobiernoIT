using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class NMVe5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_Templates",
                columns: new[] { "Name", "CategoryId", "ConnectorName", "Contents", "DeactivationDate", "Deletable", "GroupId", "Observations", "ParametersInfo", "Subject", "Type" },
                values: new object[] { "NEW_CASE_CLIENT", null, "NOTIFICATION_EMAIL", "Se ha creado un nuevo caso {CASE_ID}", null, false, null, null, "{PREV_CONTENT}, {CASE_ID}", "{SUBJECT}", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_Templates",
                keyColumn: "Name",
                keyValue: "NEW_CASE_CLIENT");
        }
    }
}
