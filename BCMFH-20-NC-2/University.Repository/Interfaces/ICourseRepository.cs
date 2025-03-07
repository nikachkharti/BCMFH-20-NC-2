using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface ICourseRepository : IRepositoryBase<Course>, IUpdatable<Course>, ISavable
    {
    }
}
