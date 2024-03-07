using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class ChangedRequuirement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Requirements__Groups_DocumentGroupId",
                table: "_Requirements");

            migrationBuilder.DropIndex(
                name: "IX__Requirements_DocumentGroupId",
                table: "_Requirements");

            migrationBuilder.DropColumn(
                name: "DocumentGroupId",
                table: "_Requirements");

            migrationBuilder.DropColumn(
                name: "DocumentUploadDate",
                table: "_Requirements");

            migrationBuilder.DropColumn(
                name: "DocumentUploaderUserId",
                table: "_Requirements");

            migrationBuilder.AddColumn<Guid>(
                name: "DocumentDescriptorId",
                table: "_Requirements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX__Requirements_DocumentDescriptorId",
                table: "_Requirements",
                column: "DocumentDescriptorId");

            migrationBuilder.AddForeignKey(
                name: "FK__Requirements__FileDescriptors_DocumentDescriptorId",
                table: "_Requirements",
                column: "DocumentDescriptorId",
                principalTable: "_FileDescriptors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Requirements__FileDescriptors_DocumentDescriptorId",
                table: "_Requirements");

            migrationBuilder.DropIndex(
                name: "IX__Requirements_DocumentDescriptorId",
                table: "_Requirements");

            migrationBuilder.DropColumn(
                name: "DocumentDescriptorId",
                table: "_Requirements");

            migrationBuilder.AddColumn<int>(
                name: "DocumentGroupId",
                table: "_Requirements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DocumentUploadDate",
                table: "_Requirements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentUploaderUserId",
                table: "_Requirements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX__Requirements_DocumentGroupId",
                table: "_Requirements",
                column: "DocumentGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK__Requirements__Groups_DocumentGroupId",
                table: "_Requirements",
                column: "DocumentGroupId",
                principalTable: "_Groups",
                principalColumn: "Id");
        }
    }
}
