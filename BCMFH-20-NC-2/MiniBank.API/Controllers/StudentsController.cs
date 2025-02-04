using Microsoft.AspNetCore.Mvc;

namespace MiniBank.API.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
    }

    [ApiController]
    [Route("students")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new()
        {
            new Student() { Id = 1, Name = "Giorgi Otarashvili"},
            new Student() { Id = 2, Name = "Ketevan Gomiashvili"},
            new Student() { Id = 3, Name = "Luka Jamrishvili"}
        };

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            if (_students.Any())
            {
                return Ok(_students);
            }

            return NotFound();
        }


        [HttpGet("{id}")]
        public IActionResult GetSingleStudent([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest($"Argument id can't be a zero or negative number");
            }

            var result = _students.FirstOrDefault(x => x.Id == id);

            if (result is null)
            {
                return NotFound($"Student with id {id} not found");
            }

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteStudent([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest($"Argument id can't be a zero or negative number");
            }

            var result = _students.FirstOrDefault(x => x.Id == id);

            if (result is null)
            {
                return NotFound($"Student with id {id} not found");
            }

            _students.Remove(result);
            return NoContent();
        }


        [HttpPost]
        public IActionResult AddStudent([FromBody] Student model)
        {
            if (model is null)
            {
                return BadRequest($"Argument can't be a null value");
            }

            var newId = _students.Max(x => x.Id) + 1;
            model.Id = newId;

            _students.Add(model);

            return Created();
        }


        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Student model)
        {
            if (model is null)
            {
                return BadRequest($"Argument can't be a null value");
            }

            var studentToUpdate = _students.FirstOrDefault(x => x.Id == model.Id);

            if (studentToUpdate is null)
            {
                return NotFound($"No student found to update");
            }

            _students.Remove(studentToUpdate);

            studentToUpdate.Name = model.Name;

            _students.Add(model);

            return Ok(studentToUpdate);
        }


        //[HttpGet("{id}")]
        //public Student GetSingleStudent([FromRoute] int id)
        //{
        //    var result = _students.FirstOrDefault(x => x.Id == id);
        //    return result;
        //}


        //[HttpGet]
        //public Student GetSingleStudent([FromBody] int id)
        //{
        //    var result = _students.FirstOrDefault(x => x.Id == id);
        //    return result;
        //}


        //[HttpGet]
        //public Student GetSingleStudent([FromForm] int id)
        //{
        //    var result = _students.FirstOrDefault(x => x.Id == id);
        //    return result;
        //}

        //[HttpGet]
        //public Student GetSingleStudent([FromHeader] int id)
        //{
        //    var result = _students.FirstOrDefault(x => x.Id == id);
        //    return result;
        //}




    }
}
