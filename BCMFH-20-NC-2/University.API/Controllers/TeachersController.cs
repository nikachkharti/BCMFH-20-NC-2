using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Models.Entities;
using University.Repository.Interfaces;

namespace University.API.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeachersController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher([FromBody] Teacher model)
        {
            await _teacherRepository.Add(model);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher([FromRoute] int id)
        {
            await _teacherRepository.Delete(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacher([FromBody] Teacher model)
        {
            await _teacherRepository.Update(model);
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
            var result = await _teacherRepository.GetAll();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacher([FromRoute] int id)
        {
            var result = await _teacherRepository.Get(id);
            return Ok(result);
        }
    }
}
