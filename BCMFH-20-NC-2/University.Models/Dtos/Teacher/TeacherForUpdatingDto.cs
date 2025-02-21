using System.ComponentModel.DataAnnotations;

namespace University.Models.Dtos.Teacher
{
    public class TeacherForUpdatingDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
