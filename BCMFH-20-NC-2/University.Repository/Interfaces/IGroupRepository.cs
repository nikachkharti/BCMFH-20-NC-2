using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface IGroupRepository : IRepositoryBase<Group>, IUpdatable<Group>
    {
    }
}
