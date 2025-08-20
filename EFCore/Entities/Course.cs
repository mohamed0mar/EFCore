using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        //public ICollection<Student> Students { get; set; }=new HashSet<Student>(); // Navigation Property
        public ICollection<Student_Course> Student_Courses { get; set; }=new HashSet<Student_Course>(); // Navigation Property
    }
}
