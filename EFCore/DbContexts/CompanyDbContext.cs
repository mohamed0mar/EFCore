using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DbContexts
{
    //this the class that responsible for managing the database connection and mapping the entities to the database tables
    internal class CompanyDbContext : DbContext 
    {
        //public CompanyDbContext(): base()
        //{
            
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            =>optionsBuilder.UseSqlServer("Server=MOHAMEDMAHMOUD\\SS22;Database=CompanyDb;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// --- Configure Employee_FluentAPI Entity ---

            //// Configure Name property
            //modelBuilder.Entity<Employee_FluentAPI>()
            //    .Property(e => e.Name)
            //    .IsRequired()                       // Name is required (NOT NULL)
            //    .HasMaxLength(100)         // Maximum length = 100
            //    .HasColumnType("varchar"); // Store as varchar instead of nvarchar

            //// Configure Salary property
            //modelBuilder.Entity<Employee_FluentAPI>()
            //    .Property(e => e.Salary)
            //    .IsRequired()                               // Salary is required
            //    .HasColumnName("EmployeeSalary")      // Rename column to EmployeeSalary
            //    .HasColumnType("decimal(18,2)");  // Decimal with 18 total digits, 2 after decimal

            //// Configure Age property
            //modelBuilder.Entity<Employee_FluentAPI>()
            //    .Property(e => e.Age)
            //    .HasColumnType("int")                                           // Store as int
            //    .HasComputedColumnSql("DATEDIFF(year, '2000-01-01', GETDATE())");
            //// Computed column: calculates age based on year difference

            //// Note:
            //// No need to call base.OnModelCreating(modelBuilder)
            //// because the DbContext does not contain a DbSet for this entity.



            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department) // Define relationship with Department
            //    .WithMany(d => d.Employees); // One Department can have many Employees

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees) // Define relationship with Employees
            //    .WithOne(e => e.Department) // One Employee belongs to one Department
            //    .HasForeignKey(e => e.DepartmentId); // Foreign key in Employee table

            ///Here We Should To Get All Configuration Classes
            ///This Method Will Automatically Apply All Configurations From The Current Assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        //public DbSet<Employee_DataAnnotations> Employees_DataAnnotations { get; set; }
        //public DbSet<Employee_FluentAPI> Employees_FluentAPI { get; set; }


    }
}
