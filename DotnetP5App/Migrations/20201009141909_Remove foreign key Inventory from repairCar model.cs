using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetP5App.Migrations
{
    public partial class RemoveforeignkeyInventoryfromrepairCarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairCars_Inventories_InventoryId",
                table: "RepairCars");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "RepairCars",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCars_Inventories_InventoryId",
                table: "RepairCars",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairCars_Inventories_InventoryId",
                table: "RepairCars");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryId",
                table: "RepairCars",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCars_Inventories_InventoryId",
                table: "RepairCars",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
