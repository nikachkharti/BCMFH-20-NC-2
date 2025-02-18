using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task<Student> Get(int id);
        Task Add(Student model);
        Task Update(Student model);
        Task Delete(int id);
    }
}
