using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class NMVe2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "_Connectors",
                keyColumn: "Name",
                keyValue: "NOTIFICATION_EMAIL",
                columns: new[] { "SmtpPassword", "SmtpUsername" },
                values: new object[] { "@2023$hD", "helpdesk@nutec.es" });

            migrationBuilder.InsertData(
                table: "_Templates",
                columns: new[] { "Name", "CategoryId", "ConnectorName", "Contents", "DeactivationDate", "Deletable", "GroupId", "Observations", "ParametersInfo", "Subject", "Type" },
                values: new object[,]
                {
                    { "FOLLOWUP_CLIENT", null, "NOTIFICATION_EMAIL", "{PREV_CONTENT}", null, false, null, null, "{PREV_CONTENT}", null, 1 },
                    { "FOLLOWUP_TECHNICIAN", null, "NOTIFICATION_EMAIL", "<$--ESCRIBE ARRIBA--$> {PREV_CONTENT}", null, false, null, null, "{PREV_CONTENT}", null, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_Templates",
                keyColumn: "Name",
                keyValue: "FOLLOWUP_CLIENT");

            migrationBuilder.DeleteData(
                table: "_Templates",
                keyColumn: "Name",
                keyValue: "FOLLOWUP_TECHNICIAN");

            migrationBuilder.UpdateData(
                table: "_Connectors",
                keyColumn: "Name",
                keyValue: "NOTIFICATION_EMAIL",
                columns: new[] { "SmtpPassword", "SmtpUsername" },
                values: new object[] { "Fer2023$", "hola@nutec.cloud" });
        }
    }
}
