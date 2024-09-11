using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAgency_WindowsDesktopApp.Migrations
{
    /// <inheritdoc />
    public partial class FixEnginesTableKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_FuelTypes_UserId",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_UserId",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Engines");

            migrationBuilder.RenameColumn(
                name: "TransmissionType",
                table: "Engines",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_FuelTypes_Id",
                table: "Engines",
                column: "Id",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_TransmissionTypes_Id",
                table: "Engines",
                column: "Id",
                principalTable: "TransmissionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_FuelTypes_Id",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_TransmissionTypes_Id",
                table: "Engines");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Engines",
                newName: "TransmissionType");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Engines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engines_UserId",
                table: "Engines",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_FuelTypes_UserId",
                table: "Engines",
                column: "UserId",
                principalTable: "FuelTypes",
                principalColumn: "Id");
        }
    }
}
