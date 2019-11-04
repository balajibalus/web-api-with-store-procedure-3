using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public CourseTime   CourseTime { get; set; }
    }
}
