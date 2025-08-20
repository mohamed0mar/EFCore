using EFCore.DbContexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What Is ORM
            // Entity Framework Core is a popular Object-Relational Mapper (ORM) for .NET applications.
            // ORM Is Tools To Help Me to Intract With Database Easily.
            // Object-Relational Mapping (ORM) is a programming technique for converting data between incompatible
            // type systems in object-oriented programming languages.
            // ORM allows developers to work with databases using objects,
            // ORM DO Two Things:
            // 1. Mapping =>
            // 1.1.From Code To Database Table =>Code First [Must Commen]
            // 1.2.From Database Table To Code =>Database First
            // 2. L2EF [LINQ To Entity FrameWork]=>
            // Query Object Models Using LINQ [CRUD]
            // Generation Will Follow Wchich Schema 
            /// 1. Table Per Type (TPT)
            /// 2. Table Per Hierarchy (TPH)
            /// 3. Table Per Concrete Class (TPC) 
            /// 


            #endregion

            #region Migration
            //First We Need To Install Entity Framework Core Tools
            // Migration is a way to update the database schema.
            // Important: The model [Class | Poco Class]should always match the database schema.

            // --- Common Commands ---
            // 1. Add Migration => Add-Migration MigrationName
            // 2. Apply Migration (Update Database) => Update-Database
            //    (It will apply any pending migrations)
            // 3. Remove Migration => Remove-Migration

            // --- Rollback ---
            // • Rollback ALL migrations: Update-Database -Migration 0
            // • Rollback to a specific migration: Update-Database -Migration LastMigrationName [this Must be The Last Migration]
            // • Rollback part of a migration (not the last one):
            //   - Create a new migration that undoes the previous changes.
            //   - Then run Update-Database with that migration.

            // --- Note ---
            // After running Update-Database, if you remove or rollback a migration 
            // (and it was not applied), you should also remove it from your project 
            // to keep migrations consistent.

            #endregion


            #region Mapping Ways 1.By Convention
            //EF Core Supports several ways[4] to map classes to database tables.
            // 1. By Convention => If I Have Class Name "Student" EF Core Will Create Table With Name "Students"
            // 2. By Data Annotations => If I Have Class Name "Student" EF Core Will Create Table With Name "Students"
            // 3. By Fluent API => If I Have Class Name "Student" EF Core Will Create Table With Name "Students"
            // 4. By Configuration => This JUst Organize For The 3rd Way
            // By Convention => 


            //CompanyDbContext dbContext = new CompanyDbContext();


            #endregion

            #region CRUD Operations with EF Core

            /*
                CRUD = Create, Read, Update, Delete

                1. Create => Add a new record to the database.
                2. Read   => Retrieve existing records from the database.
                3. Update => Modify an existing record in the database.
                4. Delete => Remove a record from the database.
            */

            CompanyDbContext dbContext = new CompanyDbContext(); // Create DbContext instance


            /*
                --------------------------
                🔹 Change Tracking in EF Core
                --------------------------
                EF Core keeps track of the state of entities:

                1. Added    => The entity is new and will be inserted into the database.
                2. Unchanged=> The entity has not changed, so no update will be made.
                3. Modified => The entity was updated and changes will be saved to the database.
                4. Deleted  => The entity is marked for deletion.
                5. Detached => The entity is not tracked by the DbContext.
            */

            // ---------------- CREATE ----------------
            Employee Emp1 = new Employee()
            { Age = 20, Name = "Mohamed Mahmoud", Salary = 10_000, IsActive = true };

            Employee Emp2 = new Employee()
            { Age = 25, Name = "Omar Amr", Salary = 15_000, IsActive = true };

            // dbContext.Employees.Add(Emp2);
            // dbContext.SaveChanges();   // Saves Emp2 to the database


            // ---------------- READ ----------------
            // Retrieve employees from database
            // var employees = dbContext.Employees.AsNoTracking().ToList();
            // var employees = dbContext.Employees.Where(e => e.Salary > 10_000).ToList();

            // foreach (var employee in employees)
            // {
            //     Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}, Age: {employee.Age}, Active: {employee.IsActive}");
            // }

            /*
                Note:
                - IQueryable<T> filters data in the database (SQL side).
                - IEnumerable<T> filters data in memory (C# side).
            */


            // ---------------- UPDATE ----------------
            //In Update And Delete Operations, We Need To Retrieve The Entity First
            // var employee = dbContext.Employees.SingleOrDefault(e => e.Id == 1);

            // if (employee != null)
            // {
            //     employee.Name = "Updated Name";
            //     dbContext.SaveChanges();   // Saves updated name to DB
            // }
            // else
            // {
            //     Console.WriteLine("Employee not found");
            // }


            // ---------------- DELETE ----------------
            // var employee = dbContext.Employees.SingleOrDefault(e => e.Id == 2);

            // if (employee != null)
            // {
            //     dbContext.Employees.Remove(employee);
            //     dbContext.SaveChanges();   // Deletes employee from DB
            // }

            #endregion


            #region OneToMany RelationShip
            //Navigation Properties 
            //Navigation Properties are properties in an entity that reference another entity.
            //They allow you to navigate between related entities in the database.
            //For example, if you have an Employee entity and a Department entity,
            //you can have a navigation property in Employee that references the Department it belongs to.
            //Navigation Properties By Default Not Be Loaded

            #endregion
        }
    }
}
