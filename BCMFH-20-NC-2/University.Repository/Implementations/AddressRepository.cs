using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDbContext _context;

        public AddressRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Address model)
        {
            await _context.Addresses.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var addressToDelete = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
            _context.Addresses.Remove(addressToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Address> Get(int id)
        {
            var result = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<List<Address>> GetAll()
        {
            return await _context.Addresses.ToListAsync();
        }

        public async Task Update(Address model)
        {
            var addressToUpdate = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == model.Id);

            addressToUpdate.City = model.City;
            addressToUpdate.Street = model.Street;
            addressToUpdate.StudentId = model.StudentId;

            await _context.SaveChangesAsync();
        }
    }
}
