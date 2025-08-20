using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    /// <summary>
    /// Model | POCO Class | Entity
    /// ----------------------------------------
    /// - A class that represents a table in the database.
    /// - EF Core supports several ways to map classes to database tables.
    /// - In this example, we are using **Data Annotations**. Set Of all attributes
    /// 
    /// Example:
    /// If the class name is "Student", EF Core will generate a table named "Students".
    /// </summary>
    internal class Employee_DataAnnotations
    {
        /// <summary>
        /// Primary Key
        /// - [Key] → Marks this property as the primary key.
        /// - [DatabaseGenerated(DatabaseGeneratedOption.Identity)] → Specifies that this property is an identity column.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Employee Name
        /// - [StringLength(100)] → Maximum length is 100 characters.
        /// - [MaxLength(100)] → Also sets the maximum length to 100 (redundant with StringLength).
        /// - [Column(TypeName = "varchar")] → Stores the value as varchar instead of nvarchar.
        /// </summary>
        [StringLength(100)]
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string? Name { get; set; }

        /// <summary>
        /// Salary
        /// - [Required] → This property is mandatory (cannot be null).
        /// - [Column(TypeName = "decimal(18,2)")] → Defines the column as decimal with 18 digits in total and 2 decimal places.
        /// - [Range(5_000, 100_000)] → Valid salary must be between 0 and 100,000.
        /// - [DataType(DataType.Currency)] → Indicates this value represents currency.
        /// </summary>
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(5_000, 100_000)]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        /// <summary>
        /// Age
        /// - [DataType(DataType.DateTime)] → Indicates the data type should be Date/Time.
        /// ⚠️ Note: Currently defined as int? → Consider using DateTime? if this should represent a date.
        /// </summary>
        [DataType(DataType.DateTime)]
        public int? Age { get; set; }

        /// <summary>
        /// Status
        /// - Nullable boolean.
        /// - Indicates whether the employee is active.
        /// </summary>
        public bool? IsActive { get; set; }

        //Derived Property
        public double NetSalary => Salary * 0.1;

        //public double GetNetSalary() => Salary * 0.1;

        // Notes:
        // - All these attributes are used for database mapping But not all this attributes mapped to Database .
        // - This class should be a concrete class (not abstract).
    }
}

