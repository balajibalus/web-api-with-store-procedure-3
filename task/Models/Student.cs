using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string PhNo { get; set; }
        public Teacher Teacher { get; set; }



    }
}
