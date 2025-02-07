using Example.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [ApiController]
    [Route("students")]
    public class StudentsController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetAllStudents()
        {
            throw new NotImplementedException();
        }


        [HttpGet("{id}")]
        public IActionResult GetSingleStudent([FromRoute] int id)
        {
            throw new NotImplementedException();
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
