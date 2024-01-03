using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class Casos3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Cases",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "Position", "TerminationDate", "Text", "Type" },
                values: new object[,]
                {
                    { "CaseEntryChannelCall", null, "CaseEntryChannel", null, null, null, null, "Llamada", 0 },
                    { "CaseEntryChannelChatBot", null, "CaseEntryChannel", null, null, null, null, "Chatbot", 0 },
                    { "CaseEntryChannelClientArea", null, "CaseEntryChannel", null, null, null, null, "Área cliente", 0 },
                    { "CaseEntryChannelEmail", null, "CaseEntryChannel", null, null, null, null, "Correo electrónico", 0 },
                    { "CaseEntryChannelWeb", null, "CaseEntryChannel", null, null, null, null, "Web", 0 },
                    { "CaseEntryChannelWhatsapp", null, "CaseEntryChannel", null, null, null, null, "Whatsapp", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelCall");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelChatBot");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelClientArea");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelEmail");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelWeb");

            migrationBuilder.DeleteData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelWhatsapp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Cases",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");
        }
    }
}
