using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniDepartmentProject.Migrations
{
    public partial class addRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmentId",
                table: "Personels",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departments_DepartmentId",
                table: "Personels",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departments_DepartmentId",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_DepartmentId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Personels");
        }
    }
}
