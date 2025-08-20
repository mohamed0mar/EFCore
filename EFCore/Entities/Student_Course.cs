using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    internal class Student_Course
    {

        // This class represents the many-to-many relationship between Student and Course
        //In Case I Dont Want To Add Extra Properties Like Grade So I dont Need This Class
        //The Ef Core Will Automatically Create Join Table Between Student And Course
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }

        //public Student Student { get; set; } = null!; // Navigation Property
        //public Course Course { get; set; } = null!; // Navigation Property
    }
}
