using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //Fluent API Configuration for Employe Entity
            builder.Property(e => e.Name)
                .IsRequired()                       // Name is required (NOT NULL)
                .HasMaxLength(100)         // Maximum length = 100
                .HasColumnType("varchar"); // Store as varchar instead of nvarchar

            builder.Property(e => e.Salary)
                .HasColumnType("decimal(18,2)")  // Decimal with 18 total digits, 2 after decimal
                .IsRequired()                               // Salary is required
                .HasColumnName("EmployeeSalary");      // Rename column to EmployeeSalary
            builder.Property(e => e.Age)
                .HasColumnType("int")                                           // Store as int
                .HasComputedColumnSql("DATEDIFF(year, '2000-01-01', GETDATE())"); // Computed column: calculates age based on year difference


            // Define the relationship with Department
            builder.HasOne(e => e.Department)           // Define relationship with Department
                   .WithMany(d => d.Employees)          // One Department can have many Employees
                   .HasForeignKey(e => e.DepartmentId); // Foreign key in Employee table
        }
    }
}
