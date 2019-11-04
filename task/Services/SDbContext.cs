using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Models;
using task.Models.Response;

namespace task.Services
{
    public class SDbContext:DbContext
    {
        public SDbContext(DbContextOptions<SDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseTime> CourseTimes { get; set; }
        public  virtual DbSet<StudentRegistration> StudentRegistrations { get; set; }

        public virtual DbQuery<StudentResponse> StudentResponses { get; set; }
    }
}
