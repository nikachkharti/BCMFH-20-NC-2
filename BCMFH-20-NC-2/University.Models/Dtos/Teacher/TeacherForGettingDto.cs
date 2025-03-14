using University.Models.Dtos.Course;

namespace University.Models.Dtos.Teacher
{
    public class TeacherForGettingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CourseForGettingDto> Courses { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
