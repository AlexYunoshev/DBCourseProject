using Microsoft.EntityFrameworkCore.Migrations;

namespace DBCourseProject.DataAccess.Migrations
{
    public partial class addPlates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FreePlate_Departments_DepartmentId",
                table: "FreePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_PayablePlate_Departments_DepartmentId",
                table: "PayablePlate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PayablePlate",
                table: "PayablePlate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreePlate",
                table: "FreePlate");

            migrationBuilder.RenameTable(
                name: "PayablePlate",
                newName: "PayablePlates");

            migrationBuilder.RenameTable(
                name: "FreePlate",
                newName: "FreePlates");

            migrationBuilder.RenameIndex(
                name: "IX_PayablePlate_DepartmentId",
                table: "PayablePlates",
                newName: "IX_PayablePlates_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_FreePlate_DepartmentId",
                table: "FreePlates",
                newName: "IX_FreePlates_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayablePlates",
                table: "PayablePlates",
                columns: new[] { "PlateId", "DepartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreePlates",
                table: "FreePlates",
                columns: new[] { "PlateId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FreePlates_Departments_DepartmentId",
                table: "FreePlates",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayablePlates_Departments_DepartmentId",
                table: "PayablePlates",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FreePlates_Departments_DepartmentId",
                table: "FreePlates");

            migrationBuilder.DropForeignKey(
                name: "FK_PayablePlates_Departments_DepartmentId",
                table: "PayablePlates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PayablePlates",
                table: "PayablePlates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FreePlates",
                table: "FreePlates");

            migrationBuilder.RenameTable(
                name: "PayablePlates",
                newName: "PayablePlate");

            migrationBuilder.RenameTable(
                name: "FreePlates",
                newName: "FreePlate");

            migrationBuilder.RenameIndex(
                name: "IX_PayablePlates_DepartmentId",
                table: "PayablePlate",
                newName: "IX_PayablePlate_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_FreePlates_DepartmentId",
                table: "FreePlate",
                newName: "IX_FreePlate_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PayablePlate",
                table: "PayablePlate",
                columns: new[] { "PlateId", "DepartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FreePlate",
                table: "FreePlate",
                columns: new[] { "PlateId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FreePlate_Departments_DepartmentId",
                table: "FreePlate",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayablePlate_Departments_DepartmentId",
                table: "PayablePlate",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
