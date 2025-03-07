using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        private readonly ApplicationDbContext _context;
        public AddressRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task Update(Address entity)
        {
            var entityFromDb = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb is not null)
            {
                entityFromDb.City = entity.City;
                entityFromDb.Street = entity.Street;
                entityFromDb.StudentId = entity.StudentId;
            }
        }
    }
}
