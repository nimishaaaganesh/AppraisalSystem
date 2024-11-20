using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bytestrone.AppraisalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeRoles_EmployeeRoleId",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeRoles_EmployeeRoleId",
                table: "Employees",
                column: "EmployeeRoleId",
                principalTable: "EmployeeRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeRoles_EmployeeRoleId",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeRoles_EmployeeRoleId",
                table: "Employees",
                column: "EmployeeRoleId",
                principalTable: "EmployeeRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
