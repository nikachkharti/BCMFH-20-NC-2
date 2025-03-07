﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using University.Models.Dtos.Teacher;
using University.Service.Interfaces;

namespace University.API.Controllers
{
    [Route("api/teachers")]
    [ApiController]
    //[Authorize]
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
            await _teacherService.SaveTeacher();
            ApiResponse response = new(ApiResponseMessage.successMessage, model, 201, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher([FromRoute] int id)
        {
            await _teacherService.DeleteTeacher(id);
            await _teacherService.SaveTeacher();
            ApiResponse response = new(ApiResponseMessage.successMessage, id, 204, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacher([FromBody] TeacherForUpdatingDto model)
        {
            await _teacherService.UpdateTeacher(model);
            await _teacherService.SaveTeacher();
            ApiResponse response = new(ApiResponseMessage.successMessage, model, 200, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }


        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
            var result = await _teacherService.GetMultipleTeachers();
            ApiResponse response = new(ApiResponseMessage.successMessage, result, 200, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacher([FromRoute] int id)
        {
            var result = await _teacherService.GetSingleTeacher(id);
            ApiResponse response = new(ApiResponseMessage.successMessage, result, 200, isSuccess: true);
            return StatusCode(response.StatusCode, response);
        }
    }
}
