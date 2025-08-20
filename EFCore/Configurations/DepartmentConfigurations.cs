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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasMany(d => d.Employees) // Define relationship with Employees
                   .WithOne(e => e.Department) // One Employee belongs to one Department
                   .HasForeignKey(e => e.DepartmentId); // Foreign key in Employee table
        }
    }
}
