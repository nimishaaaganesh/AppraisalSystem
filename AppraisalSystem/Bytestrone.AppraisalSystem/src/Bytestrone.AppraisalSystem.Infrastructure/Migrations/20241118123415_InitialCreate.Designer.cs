﻿// <auto-generated />
using System;
using Bytestrone.AppraisalSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bytestrone.AppraisalSystem.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241118123415_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.ContributorAggregate.Contributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.CycleAggregate.Cycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Quarter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Cycles");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.EmployeeAggregate.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmployeeLevelId")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeRoleId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeLevelId");

                    b.HasIndex("EmployeeRoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate.EmployeeLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employeelevels");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate.EmployeeRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmployeeRoles");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.PerformanceFactor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PerformanceFactors");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.PerformanceIndicator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FactorId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("performanceFactorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("performanceFactorId");

                    b.ToTable("PerformanceIndicators");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CycleId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmployeeLevelId")
                        .HasColumnType("integer");

                    b.Property<int>("FactorId")
                        .HasColumnType("integer");

                    b.Property<int>("IndicatorId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int?>("employeeRoleId")
                        .HasColumnType("integer");

                    b.Property<int?>("performanceFactorId")
                        .HasColumnType("integer");

                    b.Property<int?>("performanceIndicatorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CycleId");

                    b.HasIndex("EmployeeLevelId");

                    b.HasIndex("employeeRoleId");

                    b.HasIndex("performanceFactorId");

                    b.HasIndex("performanceIndicatorId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.Weightage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CycleId")
                        .HasColumnType("integer");

                    b.Property<int>("FactorId")
                        .HasColumnType("integer");

                    b.Property<int>("LevelId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("WeightageValue")
                        .HasColumnType("integer");

                    b.Property<int?>("employeeLevelId")
                        .HasColumnType("integer");

                    b.Property<int?>("employeeRoleId")
                        .HasColumnType("integer");

                    b.Property<int?>("performanceFactorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CycleId");

                    b.HasIndex("employeeLevelId");

                    b.HasIndex("employeeRoleId");

                    b.HasIndex("performanceFactorId");

                    b.ToTable("weightages");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.ContributorAggregate.Contributor", b =>
                {
                    b.OwnsOne("Bytestrone.AppraisalSystem.Core.ContributorAggregate.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<int>("ContributorId")
                                .HasColumnType("integer");

                            b1.Property<string>("CountryCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Extension")
                                .HasColumnType("text");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("ContributorId");

                            b1.ToTable("Contributors");

                            b1.WithOwner()
                                .HasForeignKey("ContributorId");
                        });

                    b.Navigation("PhoneNumber");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.EmployeeAggregate.Employee", b =>
                {
                    b.HasOne("Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate.EmployeeLevel", "Level")
                        .WithMany()
                        .HasForeignKey("EmployeeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate.EmployeeRole", "Role")
                        .WithMany()
                        .HasForeignKey("EmployeeRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.PerformanceIndicator", b =>
                {
                    b.HasOne("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.PerformanceFactor", "performanceFactor")
                        .WithMany()
                        .HasForeignKey("performanceFactorId");

                    b.Navigation("performanceFactor");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.Question", b =>
                {
                    b.HasOne("Bytestrone.AppraisalSystem.Core.CycleAggregate.Cycle", "cycle")
                        .WithMany()
                        .HasForeignKey("CycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate.EmployeeLevel", "employeeLevel")
                        .WithMany()
                        .HasForeignKey("EmployeeLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate.EmployeeRole", "employeeRole")
                        .WithMany()
                        .HasForeignKey("employeeRoleId");

                    b.HasOne("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.PerformanceFactor", "performanceFactor")
                        .WithMany()
                        .HasForeignKey("performanceFactorId");

                    b.HasOne("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.PerformanceIndicator", "performanceIndicator")
                        .WithMany()
                        .HasForeignKey("performanceIndicatorId");

                    b.Navigation("cycle");

                    b.Navigation("employeeLevel");

                    b.Navigation("employeeRole");

                    b.Navigation("performanceFactor");

                    b.Navigation("performanceIndicator");
                });

            modelBuilder.Entity("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.Weightage", b =>
                {
                    b.HasOne("Bytestrone.AppraisalSystem.Core.CycleAggregate.Cycle", "cycle")
                        .WithMany()
                        .HasForeignKey("CycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bytestrone.AppraisalSystem.Core.EmployeeLevelAggregate.EmployeeLevel", "employeeLevel")
                        .WithMany()
                        .HasForeignKey("employeeLevelId");

                    b.HasOne("Bytestrone.AppraisalSystem.Core.EmployeeRoleAggregate.EmployeeRole", "employeeRole")
                        .WithMany()
                        .HasForeignKey("employeeRoleId");

                    b.HasOne("Bytestrone.AppraisalSystem.Core.PerformanceFactorAggregate.PerformanceFactor", "performanceFactor")
                        .WithMany()
                        .HasForeignKey("performanceFactorId");

                    b.Navigation("cycle");

                    b.Navigation("employeeLevel");

                    b.Navigation("employeeRole");

                    b.Navigation("performanceFactor");
                });
#pragma warning restore 612, 618
        }
    }
}
