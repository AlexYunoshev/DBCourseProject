﻿// <auto-generated />
using DBCourseProject.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBCourseProject.DataAccess.Migrations
{
    [DbContext(typeof(CourseProjectContext))]
    [Migration("20211219133127_updateDepartments1")]
    partial class updateDepartments1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBCourseProject.Domain.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DBCourseProject.Domain.FreePlate", b =>
                {
                    b.Property<int>("PlateId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("PlateValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlateId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("FreePlate");
                });

            modelBuilder.Entity("DBCourseProject.Domain.PayablePlate", b =>
                {
                    b.Property<int>("PlateId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("PlateValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlateId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("PayablePlate");
                });

            modelBuilder.Entity("DBCourseProject.Domain.FreePlate", b =>
                {
                    b.HasOne("DBCourseProject.Domain.Department", "Department")
                        .WithMany("FreePlates")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DBCourseProject.Domain.PayablePlate", b =>
                {
                    b.HasOne("DBCourseProject.Domain.Department", "Department")
                        .WithMany("PayablePlates")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DBCourseProject.Domain.Department", b =>
                {
                    b.Navigation("FreePlates");

                    b.Navigation("PayablePlates");
                });
#pragma warning restore 612, 618
        }
    }
}
