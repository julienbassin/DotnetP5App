using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetP5App.Migrations
{
    public partial class RemoveCarIdfromrepairCarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairCars_Cars_CarId",
                table: "RepairCars");

            migrationBuilder.DropColumn(
                name: "RepairedDate",
                table: "RepairCars");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "RepairCars",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_RepairCars_Cars_CarId",
                table: "RepairCars");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "RepairCars",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RepairedDate",
                table: "RepairCars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCars_Cars_CarId",
                table: "RepairCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
