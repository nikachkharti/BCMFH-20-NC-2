using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface IAddressRepository : IRepositoryBase<Address>, IUpdatable<Address>, ISavable
    {
    }
}
