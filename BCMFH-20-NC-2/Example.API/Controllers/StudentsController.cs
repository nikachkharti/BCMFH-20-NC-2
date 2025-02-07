using Example.API.Models;
using Example.API.Services;
using Example.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [ApiController]
    [Route("students")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentSerivce;
        public StudentsController(IStudentService studentService)
        {
            _studentSerivce = studentService;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var result = _studentSerivce.GetAllStudents();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetSingleStudent([FromRoute] int id)
        {
            var result = _studentSerivce.GetSingleStudent(id);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent([FromRoute] int id)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        public IActionResult AddStudent([FromBody] Student model)
        {
            throw new NotImplementedException();
        }


        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Student model)
        {
            throw new NotImplementedException();
        }

    }
}
