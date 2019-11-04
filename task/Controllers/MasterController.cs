using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Models;
using task.Models.Response;
using task.Services;

namespace task.Controllers
{
    [Route("api/master")]
    [ApiController]
    public class MasterController : Controller
    {
        private IRepository _repository;
        public MasterController(IRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("School")]
        public IActionResult GetAllSchool()
        {
            var schools = _repository.GetSchools();
            return Ok(schools);
        }
        //[HttpGet("send/{Id}")]
        //public IActionResult Sendmsg(int Id)
        //{
        //    var item = _repository.SendMsg(Id);
        //    return Ok(item);


        //}
        [HttpGet("School/{Id}")]
        public IActionResult GetSchoolsById(int Id)
        {
            return Ok(_repository.GetSchoolsById(Id));
        }
        [HttpGet("Times")]
        public IActionResult GetTimes()
        {
            return Ok(_repository.GetTimes());
        }
        [HttpPost("Times")]
        public IActionResult AddTimes(CourseTime courseTime)
        {
            return Ok(_repository.AddTimes(courseTime));
        }
        [HttpGet("Response")]
        public List<StudentResponse> GetResponses()
        {
            return _repository.GetResponses();
        }
        [HttpGet("Gender/{Gender}")]
        public List<StudentResponse> GetResponsesGender(string Gender)
        {
            return _repository.GetResponsesGender(Gender);

        }
        [HttpGet("search")]
        List<StudentResponse> GetResponsesByNameAddress(string Name, string Address)
        {
            return _repository.GetResponsesByNameAddress(Name, Address);
        }
        [HttpGet("ss")]
        public List<StudentResponse> GetByThreeParameter(string Name, string Address, string CourseName)
        {
            return _repository.GetByThreeParameter(Name, Address, CourseName);
        }
        [HttpPost("sp")]
        public List<CourseTime> AddTimesBySp(CourseTime sp)
        {
            return _repository.AddTimesBySp(sp);
        }
    }
}
