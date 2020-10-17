using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetP5App.Migrations
{
    public partial class RemoveFKCarIdfromrepairCarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairCars_Cars_CarId",
                table: "RepairCars");

            migrationBuilder.DropIndex(
                name: "IX_RepairCars_CarId",
                table: "RepairCars");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "RepairCars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "RepairCars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairCars_CarId",
                table: "RepairCars",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCars_Cars_CarId",
                table: "RepairCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
