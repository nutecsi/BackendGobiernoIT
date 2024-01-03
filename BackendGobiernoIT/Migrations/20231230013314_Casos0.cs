using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class Casos0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "Position", "TerminationDate", "Text", "Type" },
                values: new object[,]
                {
                    { "CaseCategoryConsulta", null, "CaseCategory", null, null, null, null, "Consulta", 0 },
                    { "CaseCategoryIncidence", null, "CaseCategory", null, null, null, null, "Incidencia", 0 },
                    { "CaseCategoryRequest", null, "CaseCategory", null, null, null, null, "Petición", 0 },
                    { "CaseCategorySecurity", null, "CaseCategory", null, null, null, null, "Seguridad", 0 },
                    { "CaseClassificationTag0", null, "CaseClassificationTag", null, null, null, null, "0", 0 },
                    { "CaseClassificationTag1", null, "CaseClassificationTag", null, null, null, null, "1", 0 },
                    { "CaseClassificationTag2", null, "CaseClassificationTag", null, null, null, null, "2", 0 },
                    { "CasePriorityHigh", null, "CasePriority", null, null, null, null, "High", 0 },
                    { "CasePriorityLow", null, "CasePriority", null, null, null, null, "Low", 0 },
                    { "CasePriorityMid", null, "CasePriority", null, null, null, null, "Mid", 0 },
                    { "CaseStatusClosed", null, "CaseStatus", null, null, null, null, "Cerrado", 0 },
                    { "CaseStatusInProgress", null, "CaseStatus", null, null, null, null, "En curso", 0 },
                    { "CaseStatusNew", null, "CaseStatus", null, null, null, null, "Nuevo", 0 },
                    { "CaseStatusPaused", null, "CaseStatus", null, null, null, null, "Pausada", 0 },
                    { "CaseStatusPendingClient", null, "CaseStatus", null, null, null, null, "Pendiente cliente", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategoryConsulta");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategoryIncidence");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategoryRequest");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategorySecurity");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseClassificationTag0");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseClassificationTag1");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseClassificationTag2");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CasePriorityHigh");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CasePriorityLow");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CasePriorityMid");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusClosed");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusInProgress");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusNew");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusPaused");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusPendingClient");
        }
    }
}
