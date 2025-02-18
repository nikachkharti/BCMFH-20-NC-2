using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface IAddressRepository
    {
        Task<List<Address>> GetAll();
        Task<Address> Get(int id);
        Task Add(Address model);
        Task Update(Address model);
        Task Delete(int id);
    }
}
