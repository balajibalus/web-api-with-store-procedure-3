using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Models;
using task.Models.Response;

namespace task.Services
{
    public interface IRepository
    {
        List<School> GetSchools();
        List<School> GetSchoolsById(int Id);
        List<Student> GetStudents();
        List<Student> GetStudentsById(int Id);
        List<CourseTime> GetTimes();

        bool AddTimes(CourseTime courseTime);
        
        List<CourseTime> AddTimesBySp(CourseTime sp);
        List<StudentResponse> GetResponses();
        List<StudentResponse> GetResponsesGender(string Gender);
        List<StudentResponse> GetResponsesByNameAddress(string Name, string Address);
        List<StudentResponse> GetByThreeParameter(string Name, string Address, string CourseName);
      //  List<Student> SendMsg(int Id);
        //string SendMail(Student student);
        

    }
}
