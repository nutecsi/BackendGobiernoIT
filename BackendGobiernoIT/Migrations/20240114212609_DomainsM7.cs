using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class DomainsM7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DomainId",
                table: "HostingsInventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HostingsInventory_DomainId",
                table: "HostingsInventory",
                column: "DomainId");

            migrationBuilder.AddForeignKey(
                name: "FK_HostingsInventory_Domains_DomainId",
                table: "HostingsInventory",
                column: "DomainId",
                principalTable: "Domains",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HostingsInventory_Domains_DomainId",
                table: "HostingsInventory");

            migrationBuilder.DropIndex(
                name: "IX_HostingsInventory_DomainId",
                table: "HostingsInventory");

            migrationBuilder.DropColumn(
                name: "DomainId",
                table: "HostingsInventory");
        }
    }
}
