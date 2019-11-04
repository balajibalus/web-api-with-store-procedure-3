using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.Models
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string PhNo { get; set; }
        public Student Student { get; set; }

    }
}
