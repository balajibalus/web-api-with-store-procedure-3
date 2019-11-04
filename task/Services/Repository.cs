using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using task.Models;
using task.Models.Response;

namespace task.Services
{
    public class Repository : IRepository
    {
        private SDbContext _sDbContext;
        public Repository(SDbContext sDbContext)
        {
            _sDbContext = sDbContext;
        }

        public bool AddTimes(CourseTime courseTime)
        {
            _sDbContext.Add(courseTime);
            var time = _sDbContext.SaveChanges();
            return time > 0 ? true : false;
        }

        public List<CourseTime> AddTimesBySp(CourseTime sp)
        {
            return _sDbContext.CourseTimes.FromSql("addsp", sp).ToList();
        }

        public List<StudentResponse> GetByThreeParameter(string Name, string Address, string CourseName)
        {
            return _sDbContext.StudentResponses.FromSql("RESPONSEBYNAC @p0,@p1,@p2", Name, Address, CourseName).ToList();
        }

        public List<StudentResponse> GetResponses()
        {
            return _sDbContext.StudentResponses.FromSql("RESPONSE").ToList();
        }

        public List<StudentResponse> GetResponsesByNameAddress(string Name, string Address)
        {
            return _sDbContext.StudentResponses.FromSql("RESPONSEBYNA @p0,@p1", Name, Address).ToList();
        }

        public List<StudentResponse> GetResponsesGender(string Gender)
        {
            return _sDbContext.StudentResponses.FromSql("RESPONSEBYGENDER @p0", Gender).ToList();
        }

        public List<School> GetSchools()
        {
            return _sDbContext.Schools.ToList();
        }

        public List<School> GetSchoolsById(int Id)
        {
            return _sDbContext.Schools.Where(s => s.Id == Id).ToList();
        }

        public List<Student> GetStudents()
        {
            return _sDbContext.Students.ToList();
        }

        public List<Student> GetStudentsById(int Id)
        {
            return _sDbContext.Students.Where(St => St.Id == Id).ToList();
        }

        public List<CourseTime> GetTimes()
        {
            return _sDbContext.CourseTimes.ToList();
        }

        //public string SendMail(Student student, Email e)
        //{
        //    if (_sDbContext.Students.Where(a => 
        //    {

        //        string subject = e.Subject;
        //        string body = e.Body;
        //        string to = e.To;
        //        MailMessage mm = new MailMessage();
        //        mm.From = new MailAddress("balaji.sandupatla@gmail.com");
        //        mm.To.Add(to);
        //        mm.Subject = subject;
        //        mm.Body = body;
        //        mm.IsBodyHtml = false;
        //        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        //        smtp.UseDefaultCredentials = true;
        //        smtp.Port = 587;
        //        smtp.EnableSsl = true;
        //        smtp.Credentials = new System.Net.NetworkCredential("balaji.sandupatla@gmail.com", "balaji@paru");
        //        smtp.Send(mm);

        //    }

        //}





        }

        //public List<Student> SendMsg(int Id)
        //{
        //    throw new NotImplementedException();
        //}
    }

