using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAgency_WindowsDesktopApp.Migrations
{
    /// <inheritdoc />
    public partial class FixEnginesTableKeys2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_FuelTypes_Id",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_TransmissionTypes_Id",
                table: "Engines");

            migrationBuilder.AddColumn<Guid>(
                name: "FuelTypeId",
                table: "Engines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TransmissionTypeId",
                table: "Engines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Engines_FuelTypeId",
                table: "Engines",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_TransmissionTypeId",
                table: "Engines",
                column: "TransmissionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_FuelTypes_FuelTypeId",
                table: "Engines",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_TransmissionTypes_TransmissionTypeId",
                table: "Engines",
                column: "TransmissionTypeId",
                principalTable: "TransmissionTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_FuelTypes_FuelTypeId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_TransmissionTypes_TransmissionTypeId",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_FuelTypeId",
                table: "Engines");

            migrationBuilder.DropIndex(
                name: "IX_Engines_TransmissionTypeId",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "FuelTypeId",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "TransmissionTypeId",
                table: "Engines");

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
    }
}
