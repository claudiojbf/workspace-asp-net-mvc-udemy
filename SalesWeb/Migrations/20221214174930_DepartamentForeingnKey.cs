using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWeb.Migrations
{
    public partial class DepartamentForeingnKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Departament_DepartmentId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Sellers");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "Sellers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_DepartamentId",
                table: "Sellers",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Departament_DepartamentId",
                table: "Sellers",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Departament_DepartamentId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_DepartamentId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "Sellers");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Sellers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Departament_DepartmentId",
                table: "Sellers",
                column: "DepartmentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
