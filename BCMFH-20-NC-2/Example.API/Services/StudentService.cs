using Example.API.Models;
using Example.API.Services.Exceptions;

namespace Example.API.Services
{
    public class StudentService
    {
        private static List<Student> _students = new()
        {
            new Student() { Id = 1, Name = "Giorgi Otarashvili"},
            new Student() { Id = 2, Name = "Ketevan Gomiashvili"},
            new Student() { Id = 3, Name = "Luka Jamrishvili"}
        };

        List<Student> GetAllStudents()
        {
            if (_students.Any())
            {
                return _students;
            }

            throw new NotFoundException("Students not found");
        }

        Student GetSingleStudent(int studentId)
        {
            if (studentId <= 0)
            {
                throw new ArgumentException($"Argument id can't be a zero or negative number");
            }

            var result = _students.FirstOrDefault(x => x.Id == studentId);

            if (result is null)
            {
                throw new NotFoundException($"Student with id {studentId} not found");
            }

            return result;
        }

        void DeleteStudent(int studentId)
        {
            if (studentId <= 0)
            {
                throw new ArgumentException($"Argument id can't be a zero or negative number");
            }

            var result = _students.FirstOrDefault(x => x.Id == studentId);

            if (result is null)
            {
                throw new NotFoundException($"Student with id {studentId} not found");
            }

            _students.Remove(result);
        }

        void AddStudent(Student model)
        {
            if (model is null)
            {
                throw new ArgumentException($"Argument can't be a null value");
            }

            var newId = _students.Max(x => x.Id) + 1;
            model.Id = newId;

            _students.Add(model);
        }

        void UpdateStudent(Student model)
        {
            if (model is null)
            {
                throw new ArgumentException($"Argument can't be a null value");
            }

            var studentToUpdate = _students.FirstOrDefault(x => x.Id == model.Id);

            if (studentToUpdate is null)
            {
                throw new NotFoundException($"No student found to update");
            }

            _students.Remove(studentToUpdate);
            studentToUpdate.Name = model.Name;

            _students.Add(model);
        }

    }
}
