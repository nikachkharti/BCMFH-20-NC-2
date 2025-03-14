using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace University.Models.Dtos.Teacher
{
    public class TeacherForCreatingDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public IFormFile ProfilePicture { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
