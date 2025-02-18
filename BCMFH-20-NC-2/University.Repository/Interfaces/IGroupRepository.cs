using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface IGroupRepository
    {
        Task<List<Group>> GetAll();
        Task<Group> Get(int id);
        Task Add(Group model);
        Task Update(Group model);
        Task Delete(int id);
    }
}
