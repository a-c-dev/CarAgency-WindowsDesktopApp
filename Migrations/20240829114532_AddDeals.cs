using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAgency_WindowsDesktopApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDeals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CasrStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KmsDriven = table.Column<long>(type: "bigint", nullable: true),
                    Year = table.Column<DateOnly>(type: "date", nullable: true),
                    OwnerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasrStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CasrStatuses_OwnerTypes_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalTable: "OwnerTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: true),
                    DealerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SellerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CarModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CarStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deals_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deals_SellerTypes_CarStatusId",
                        column: x => x.CarStatusId,
                        principalTable: "SellerTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deals_SellerTypes_SellerTypeId",
                        column: x => x.SellerTypeId,
                        principalTable: "SellerTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CasrStatuses_OwnerTypeId",
                table: "CasrStatuses",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_CarModelId",
                table: "Deals",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_CarStatusId",
                table: "Deals",
                column: "CarStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_DealerId",
                table: "Deals",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_SellerTypeId",
                table: "Deals",
                column: "SellerTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CasrStatuses");

            migrationBuilder.DropTable(
                name: "Deals");
        }
    }
}
