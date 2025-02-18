using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAll();
        Task<Course> Get(int id);
        Task Add(Course model);
        Task Update(Course model);
        Task Delete(int id);
    }
}
