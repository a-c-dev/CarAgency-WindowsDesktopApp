using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAgency_WindowsDesktopApp.Migrations
{
    /// <inheritdoc />
    public partial class AddEnginesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    TransmissionType = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PowerCC = table.Column<int>(type: "int", nullable: true),
                    MaxPowerBhp = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    TorqueNm = table.Column<long>(type: "bigint", nullable: true),
                    TorqueRpmMin = table.Column<long>(type: "bigint", nullable: true),
                    TorqueRpmMax = table.Column<long>(type: "bigint", nullable: true),
                    MileageKmpl = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.TransmissionType);
                    table.ForeignKey(
                        name: "FK_Engines_FuelTypes_UserId",
                        column: x => x.UserId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engines_UserId",
                table: "Engines",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engines");
        }
    }
}
