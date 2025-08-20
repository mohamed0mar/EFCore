using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    // 3. By Fluent API => We Can Use Fluent API To Configure The Model
    //We Use Fluent API In This Cases:
    // 1. If We Dont have Source Code Of The Model
    ///The Fluent API is a way to configure the model using code instead of attributes.
    ///We Override the OnModelCreating method in the DbContext class to configure the model.

    internal class Employee_FluentAPI
    {

        public int Id { get; set; }
        public string? Name { get; set; }

        public double Salary { get; set; }

        public int? Age { get; set; }

        public bool? IsActive { get; set; }

    }
}

