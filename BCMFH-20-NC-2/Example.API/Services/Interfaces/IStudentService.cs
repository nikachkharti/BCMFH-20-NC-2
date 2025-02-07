using Example.API.Models;

namespace Example.API.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetSingleStudent(int studentId);
        void DeleteStudent(int studentId);
        void AddStudent(Student model);
        void UpdateStudent(Student model);
    }
}
