using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bytestrone.AppraisalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contributors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber_CountryCode = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber_Number = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber_Extension = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quarter = table.Column<string>(type: "text", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employeelevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeelevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceFactors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceFactors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeRoleId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeLevelId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeRoles_EmployeeRoleId",
                        column: x => x.EmployeeRoleId,
                        principalTable: "EmployeeRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Employeelevels_EmployeeLevelId",
                        column: x => x.EmployeeLevelId,
                        principalTable: "Employeelevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceIndicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FactorId = table.Column<int>(type: "integer", nullable: false),
                    performanceFactorId = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceIndicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerformanceIndicators_PerformanceFactors_performanceFactorId",
                        column: x => x.performanceFactorId,
                        principalTable: "PerformanceFactors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "weightages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    employeeRoleId = table.Column<int>(type: "integer", nullable: true),
                    LevelId = table.Column<int>(type: "integer", nullable: false),
                    employeeLevelId = table.Column<int>(type: "integer", nullable: true),
                    FactorId = table.Column<int>(type: "integer", nullable: false),
                    performanceFactorId = table.Column<int>(type: "integer", nullable: true),
                    CycleId = table.Column<int>(type: "integer", nullable: false),
                    WeightageValue = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weightages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_weightages_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_weightages_EmployeeRoles_employeeRoleId",
                        column: x => x.employeeRoleId,
                        principalTable: "EmployeeRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_weightages_Employeelevels_employeeLevelId",
                        column: x => x.employeeLevelId,
                        principalTable: "Employeelevels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_weightages_PerformanceFactors_performanceFactorId",
                        column: x => x.performanceFactorId,
                        principalTable: "PerformanceFactors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FactorId = table.Column<int>(type: "integer", nullable: false),
                    performanceFactorId = table.Column<int>(type: "integer", nullable: true),
                    IndicatorId = table.Column<int>(type: "integer", nullable: false),
                    performanceIndicatorId = table.Column<int>(type: "integer", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    employeeRoleId = table.Column<int>(type: "integer", nullable: true),
                    EmployeeLevelId = table.Column<int>(type: "integer", nullable: false),
                    CycleId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_EmployeeRoles_employeeRoleId",
                        column: x => x.employeeRoleId,
                        principalTable: "EmployeeRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Questions_Employeelevels_EmployeeLevelId",
                        column: x => x.EmployeeLevelId,
                        principalTable: "Employeelevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_PerformanceFactors_performanceFactorId",
                        column: x => x.performanceFactorId,
                        principalTable: "PerformanceFactors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Questions_PerformanceIndicators_performanceIndicatorId",
                        column: x => x.performanceIndicatorId,
                        principalTable: "PerformanceIndicators",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeLevelId",
                table: "Employees",
                column: "EmployeeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeRoleId",
                table: "Employees",
                column: "EmployeeRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceIndicators_performanceFactorId",
                table: "PerformanceIndicators",
                column: "performanceFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CycleId",
                table: "Questions",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_EmployeeLevelId",
                table: "Questions",
                column: "EmployeeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_employeeRoleId",
                table: "Questions",
                column: "employeeRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_performanceFactorId",
                table: "Questions",
                column: "performanceFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_performanceIndicatorId",
                table: "Questions",
                column: "performanceIndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_weightages_CycleId",
                table: "weightages",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_weightages_employeeLevelId",
                table: "weightages",
                column: "employeeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_weightages_employeeRoleId",
                table: "weightages",
                column: "employeeRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_weightages_performanceFactorId",
                table: "weightages",
                column: "performanceFactorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contributors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "weightages");

            migrationBuilder.DropTable(
                name: "PerformanceIndicators");

            migrationBuilder.DropTable(
                name: "Cycles");

            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.DropTable(
                name: "Employeelevels");

            migrationBuilder.DropTable(
                name: "PerformanceFactors");
        }
    }
}
