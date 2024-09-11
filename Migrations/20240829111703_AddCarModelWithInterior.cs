using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAgency_WindowsDesktopApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCarModelWithInterior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_FuelTypes_FuelTypeId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_TransmissionTypes_TransmissionTypeId",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "MaxPowerBhp",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "MileageKmpl",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "PowerCC",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "TorqueNm",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "TorqueRpmMax",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "TorqueRpmMin",
                table: "Engines");

            migrationBuilder.RenameColumn(
                name: "TransmissionTypeId",
                table: "Engines",
                newName: "InteriorId");

            migrationBuilder.RenameColumn(
                name: "FuelTypeId",
                table: "Engines",
                newName: "EngineId");

            migrationBuilder.RenameIndex(
                name: "IX_Engines_TransmissionTypeId",
                table: "Engines",
                newName: "IX_Engines_InteriorId");

            migrationBuilder.RenameIndex(
                name: "IX_Engines_FuelTypeId",
                table: "Engines",
                newName: "IX_Engines_EngineId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Engines",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PowerCC = table.Column<int>(type: "int", nullable: true),
                    MaxPowerBhp = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    TorqueNm = table.Column<long>(type: "bigint", nullable: true),
                    TorqueRpmMin = table.Column<long>(type: "bigint", nullable: true),
                    TorqueRpmMax = table.Column<long>(type: "bigint", nullable: true),
                    MileageKmpl = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    FuelTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransmissionTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engine_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Engine_TransmissionTypes_TransmissionTypeId",
                        column: x => x.TransmissionTypeId,
                        principalTable: "TransmissionTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatsNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_FuelTypeId",
                table: "Engine",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_TransmissionTypeId",
                table: "Engine",
                column: "TransmissionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_Engine_EngineId",
                table: "Engines",
                column: "EngineId",
                principalTable: "Engine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engines_Interior_InteriorId",
                table: "Engines",
                column: "InteriorId",
                principalTable: "Interior",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engines_Engine_EngineId",
                table: "Engines");

            migrationBuilder.DropForeignKey(
                name: "FK_Engines_Interior_InteriorId",
                table: "Engines");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "Interior");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Engines");

            migrationBuilder.RenameColumn(
                name: "InteriorId",
                table: "Engines",
                newName: "TransmissionTypeId");

            migrationBuilder.RenameColumn(
                name: "EngineId",
                table: "Engines",
                newName: "FuelTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Engines_InteriorId",
                table: "Engines",
                newName: "IX_Engines_TransmissionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Engines_EngineId",
                table: "Engines",
                newName: "IX_Engines_FuelTypeId");

            migrationBuilder.AddColumn<decimal>(
                name: "MaxPowerBhp",
                table: "Engines",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MileageKmpl",
                table: "Engines",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerCC",
                table: "Engines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TorqueNm",
                table: "Engines",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TorqueRpmMax",
                table: "Engines",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TorqueRpmMin",
                table: "Engines",
                type: "bigint",
                nullable: true);

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
    }
}
