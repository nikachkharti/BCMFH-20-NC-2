using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface ITeacherRepository : IRepositoryBase<Teacher>, IUpdatable<Teacher>
    {
    }
}
