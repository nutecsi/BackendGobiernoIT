using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class NMVe4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "_Templates",
                keyColumn: "Name",
                keyValue: "FOLLOWUP_CLIENT",
                columns: new[] { "ParametersInfo", "Subject" },
                values: new object[] { "{PREV_CONTENT}, {SUBJECT}", "{SUBJECT}" });

            migrationBuilder.UpdateData(
                table: "_Templates",
                keyColumn: "Name",
                keyValue: "FOLLOWUP_TECHNICIAN",
                columns: new[] { "ParametersInfo", "Subject" },
                values: new object[] { "{PREV_CONTENT}, {SUBJECT}", "{SUBJECT}" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "_Templates",
                keyColumn: "Name",
                keyValue: "FOLLOWUP_CLIENT",
                columns: new[] { "ParametersInfo", "Subject" },
                values: new object[] { "{PREV_CONTENT}", null });

            migrationBuilder.UpdateData(
                table: "_Templates",
                keyColumn: "Name",
                keyValue: "FOLLOWUP_TECHNICIAN",
                columns: new[] { "ParametersInfo", "Subject" },
                values: new object[] { "{PREV_CONTENT}", null });
        }
    }
}
