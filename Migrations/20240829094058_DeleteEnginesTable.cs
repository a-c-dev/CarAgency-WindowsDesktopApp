using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAgency_WindowsDesktopApp.Migrations
{
    /// <inheritdoc />
    public partial class DeleteEnginesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaxPowerBhp = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    MileageKmpl = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    PowerCC = table.Column<int>(type: "int", nullable: true),
                    TorqueNm = table.Column<long>(type: "bigint", nullable: true),
                    TorqueRpmMax = table.Column<long>(type: "bigint", nullable: true),
                    TorqueRpmMin = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engines_FuelTypes_Id",
                        column: x => x.Id,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engines_TransmissionTypes_Id",
                        column: x => x.Id,
                        principalTable: "TransmissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
