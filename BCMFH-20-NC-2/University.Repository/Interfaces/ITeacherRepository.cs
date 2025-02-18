using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface ITeacherRepository
    {
        Task<List<Teacher>> GetAll();
        Task<Teacher> Get(int id);
        Task Add(Teacher model);
        Task Update(Teacher model);
        Task Delete(int id);
    }
}
