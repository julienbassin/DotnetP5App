using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetP5App.Migrations
{
    public partial class RemoveInventoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Cars_CarId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Status_StatusId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairCars_Inventories_InventoryId",
                table: "RepairCars");

            migrationBuilder.DropIndex(
                name: "IX_RepairCars_InventoryId",
                table: "RepairCars");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_CarId",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_StatusId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "RepairCars");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Inventories");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "RepairCars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RepairCars_CarId",
                table: "RepairCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_StatusId",
                table: "Cars",
                column: "StatusId",
                unique: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Status_StatusId",
                table: "Cars",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCars_Cars_CarId",
                table: "RepairCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Status_StatusId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairCars_Cars_CarId",
                table: "RepairCars");

            migrationBuilder.DropIndex(
                name: "IX_RepairCars_CarId",
                table: "RepairCars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_StatusId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "RepairCars");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "RepairCars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RepairCars_InventoryId",
                table: "RepairCars",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_CarId",
                table: "Inventories",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_StatusId",
                table: "Inventories",
                column: "StatusId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Cars_CarId",
                table: "Inventories",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Status_StatusId",
                table: "Inventories",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCars_Inventories_InventoryId",
                table: "RepairCars",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
