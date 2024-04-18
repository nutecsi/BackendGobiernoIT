using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class IncidenciaManel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "SSLCertificatesInventory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumLibre1",
                table: "_GenericLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TxtLibre1",
                table: "_GenericLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Alquiler",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "API1",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "API2",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "API3",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "BusinessC",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "BusinessL",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "BusinessU",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Caracteristicas1",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Caracteristicas2",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategoryConsulta",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategoryIncidence",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategoryRequest",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseCategorySecurity",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseClassificationTag0",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseClassificationTag1",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseClassificationTag2",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelCall",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelChatBot",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelClientArea",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelEmail",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelWeb",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseEntryChannelWhatsapp",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CasePriorityHigh",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CasePriorityLow",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CasePriorityMid",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusClosed",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusInProgress",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusNew",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusPaused",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CaseStatusPendingClient",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientD",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientI",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientN",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientOriginFacebook",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientOriginInstagram",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientOriginLinkedIn",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientP",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ClientS",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CountryPhoneNumberCodeBR",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CountryPhoneNumberCodeCN",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CountryPhoneNumberCodeDE",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CountryPhoneNumberCodeES",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CountryPhoneNumberCodeFR",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CountryPhoneNumberCodeIT",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "CountryPhoneNumberCodeUK",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsCompras",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsContabilidad",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsDireccion",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DepartmentsRRHH",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DeviceTypeNAS",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DeviceTypeOrdenador",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DeviceTypePortatil",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionCAT",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionCOM",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionEDU",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionES",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DnsExtensionINFO",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DocumentTypeDNI",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DocumentTypeNIE",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "DocumentTypeNIF",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ElementL0",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ElementL1",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ElementT0",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EmissEffA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EmissEffB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffA+",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffA++",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffC",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffD",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffE",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffF",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EnergEffG",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoC",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoD",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoEC",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoEN",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoM",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoMB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoMM",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoND",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "EstadoR",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "FeatureN",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "FeatureS",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "HardDriveTypeNVMe",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "HardDriveTypeSSD",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "HostingSystemOther",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "HostingSystemPlesk",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IconA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IconB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask16",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask24",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask28",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask32",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "IPMask8",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "JobPositionCEO",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "JobPositionEmplyee",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "L0",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "L0Position",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "L1",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "L1Position",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Label1",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Label2",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LangCAT",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LangSPA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LBottom",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Legal",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LegalClassifEU",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LegalClassifSA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LegalClassifSC",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LegalClassifSL",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Local",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "LTop",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ManufacturerHP",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ManufacturerMicrosoft",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Me",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "MePosition",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Oficina",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemAndroid",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemIOS",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemLinux",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemMacOS",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemUbuntu",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemWindows10",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemWindows7",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "OperatingSystemWindowsServer2019",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Others",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Otros",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PaisA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PaisB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Parking",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Parking+Trastero",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ParkingPequeño",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PeriodoA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PeriodoM",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PeriodoS",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PeriodoT",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Pers",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Piso",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PobA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PobB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv7",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv8",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv8_2",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorARMv9",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorIntelI5",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProcessorXeon",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Prof",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PromotionA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "PromotionB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProvA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ProvB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM128GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM16GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM1TB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM256GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM2GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM32GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM4GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM512GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM64GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RAM8GB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Renta",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RolCoordinador",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RolEspecialista",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "RolInvestigador",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Rotulo",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameAdobeAcrobat",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameAutocad",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameMicrosoft365",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameSage",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareNameTeamViewer",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeDesign",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeManagement",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeOperativeSystem",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SoftwareTypeSecurity",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Sotano",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SSLCertTypeDV",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SSLCertTypeOV",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SSLCertTypeWildCard",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "SupplierNutec",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "TGroup",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "TipoA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "TipoB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "TopologyFinC",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "TopologyFinP",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Traspaso",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Trastero",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "UsageU",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Venta",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "VentaAlquiler",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "Vivienda",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ZonaA",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ZonaB",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "_GenericLists",
                keyColumn: "Id",
                keyValue: "ZonaM",
                columns: new[] { "NumLibre1", "TxtLibre1" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "SSLCertificatesInventory");

            migrationBuilder.DropColumn(
                name: "NumLibre1",
                table: "_GenericLists");

            migrationBuilder.DropColumn(
                name: "TxtLibre1",
                table: "_GenericLists");
        }
    }
}
