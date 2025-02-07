using Example.API.Models;
using Example.API.Services.Exceptions;
using Example.API.Services.Interfaces;

namespace Example.API.Services
{
    public class StudentServiceTwo : IStudentService
    {
        private static List<Student> _students = new()
        {
            new Student() { Id = 1, Name = "Mariami Nachkebia"},
            new Student() { Id = 2, Name = "Mikheil NIkoleishvili"},
            new Student() { Id = 3, Name = "Levan Gagnidze"}
        };

        public List<Student> GetAllStudents()
        {
            if (_students.Any())
            {
                return _students;
            }

            throw new NotFoundException("Students not found");
        }
        public Student GetSingleStudent(int studentId)
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
        public void DeleteStudent(int studentId)
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
        public void AddStudent(Student model)
        {
            if (model is null)
            {
                throw new ArgumentException($"Argument can't be a null value");
            }

            var newId = _students.Max(x => x.Id) + 1;
            model.Id = newId;

            _students.Add(model);
        }
        public void UpdateStudent(Student model)
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
