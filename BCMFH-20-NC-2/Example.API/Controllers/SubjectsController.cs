using Example.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    [Route("api/subjects")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public SubjectsController(IStudentService studentService)
        {
            _studentService = studentService;
        }
    }
}
