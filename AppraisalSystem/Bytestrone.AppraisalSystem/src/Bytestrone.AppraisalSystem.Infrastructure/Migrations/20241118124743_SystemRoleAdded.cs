using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bytestrone.AppraisalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SystemRoleAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employeelevels_EmployeeLevelId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Employeelevels_EmployeeLevelId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_weightages_Employeelevels_employeeLevelId",
                table: "weightages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employeelevels",
                table: "Employeelevels");

            migrationBuilder.RenameTable(
                name: "Employeelevels",
                newName: "EmployeeLevels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLevels",
                table: "EmployeeLevels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SystemRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRoles", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeLevels_EmployeeLevelId",
                table: "Employees",
                column: "EmployeeLevelId",
                principalTable: "EmployeeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_EmployeeLevels_EmployeeLevelId",
                table: "Questions",
                column: "EmployeeLevelId",
                principalTable: "EmployeeLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_weightages_EmployeeLevels_employeeLevelId",
                table: "weightages",
                column: "employeeLevelId",
                principalTable: "EmployeeLevels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeLevels_EmployeeLevelId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_EmployeeLevels_EmployeeLevelId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_weightages_EmployeeLevels_employeeLevelId",
                table: "weightages");

            migrationBuilder.DropTable(
                name: "SystemRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLevels",
                table: "EmployeeLevels");

            migrationBuilder.RenameTable(
                name: "EmployeeLevels",
                newName: "Employeelevels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employeelevels",
                table: "Employeelevels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employeelevels_EmployeeLevelId",
                table: "Employees",
                column: "EmployeeLevelId",
                principalTable: "Employeelevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Employeelevels_EmployeeLevelId",
                table: "Questions",
                column: "EmployeeLevelId",
                principalTable: "Employeelevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_weightages_Employeelevels_employeeLevelId",
                table: "weightages",
                column: "employeeLevelId",
                principalTable: "Employeelevels",
                principalColumn: "Id");
        }
    }
}
