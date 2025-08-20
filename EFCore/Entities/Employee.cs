using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    ///Model | Poco Class| Entity => Is Class That Represent Table In Database
    ///EF Core Supports several ways[4] to map classes to database tables.
    // 1. By Convention => If I Have Class Name "Employee" EF Core Will Create Table With Name "Employee"
    public class Employee
    {
        public int Id { get; set; } //Public Numeric Property [Id | EmployeeId] => PK | Idintity
        
        //public string Name { get; set; } // Public String Property [Name | EmployeeName] => NVARCHAR(Max) المفروض required
        public string? Name { get; set; } // Reference Type Property : Allow Null Valu => Optional 
       
        public double Salary { get; set; } //Value Type Property : Not Allow Null Value => Required
        public int? Age { get; set; } //Value Type Property : Allow Null Value => Optional
        public bool? IsActive { get; set; } //Value Type Property : Allow Null Value => Optional
        public int? DepartmentId { get; set; } //Forgin Key 
        public Department Department { get; set; }

        ///After We Create Employee Class We Need To Create DbContext Class
        ///And Add DbSet<Employee> Employees { get; set; } Property To It

    }
}
