using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetP5App.Migrations
{
    public partial class modifyInventoryandrepairCarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_Cars_CarId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_CarId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Status");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "RepairCars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Inventories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairCars_InventoryId",
                table: "RepairCars",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_StatusId",
                table: "Inventories",
                column: "StatusId",
                unique: true);

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_Inventories_StatusId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "RepairCars");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Inventories");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Status",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Status_CarId",
                table: "Status",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Cars_CarId",
                table: "Status",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
