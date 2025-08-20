using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }=null!; // Using null-forgiving operator to indicate that Name should not be null
        public int? Age { get; set; }
        public string? Address { get; set; }
        //public ICollection<Course> Courses { get; set; } = new HashSet<Course>(); // Navigation Property
        public ICollection<Student_Course> student_Courses { get; set; } = new HashSet<Student_Course>(); // Navigation Property
    }
}
