using Microsoft.AspNetCore.Mvc;
using University.Models.Dtos.Teacher;
using University.Service.Interfaces;

namespace University.API.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher([FromBody] TeacherForCreatingDto model)
        {
            await _teacherService.AddNewTeacher(model);
            return Created();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher([FromRoute] int id)
        {
            await _teacherService.DeleteTeacher(id);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacher([FromBody] TeacherForUpdatingDto model)
        {
            await _teacherService.UpdateTeacher(model);
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
            var result = await _teacherService.GetMultipleTeachers();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacher([FromRoute] int id)
        {
            var result = await _teacherService.GetSingleTeacher(id);
            return Ok(result);
        }
    }
}
