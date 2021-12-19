using DBCourseProject.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.DataAccess
{
    public class CourseProjectContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        //public DbSet<NumberPlate> FreePlates { get; set; }
        //public DbSet<NumberPlate> PayablePlates { get; set; }

        //public CourseProjectContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OLEKSANDRPC;Database=DBCourseProject;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FreePlate>()
                .HasKey(plate => new {plate.PlateId, plate.DepartmentId});

            modelBuilder.Entity<PayablePlate>()
              .HasKey(plate => new { plate.PlateId, plate.DepartmentId });

            modelBuilder.Entity<Department>()
               .HasMany(department => department.FreePlates)
               .WithOne(department => department.Department)
               .HasForeignKey(plate => plate.DepartmentId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
               .HasMany(department => department.PayablePlates)
               .WithOne(department => department.Department)
               .HasForeignKey(plate => plate.DepartmentId)
               .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Department>()
            //    .HasMany(freePlate => freePlate.FreePlates)
            //    .WithOne(dep => dep.FreePlateDepartment)
            //    .HasForeignKey(dep => dep.FreePlateDepartmentId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Department>()
            //    .HasMany(payablePlate => payablePlate.PayablePlates)
            //    .WithOne(dep => dep.PayablePlateDepartment)
            //    .HasForeignKey(dep => dep.PayablePlateDepartmentId)
            //    .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
