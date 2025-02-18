using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class GroupRepository : IGroupRepository
    {
        private readonly ApplicationDbContext _context;
        public GroupRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Group model)
        {
            await _context.Groups.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var groupToDelete = await _context.Groups.FirstOrDefaultAsync(x => x.Id == id);
            _context.Groups.Remove(groupToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Group> Get(int id)
        {
            var result = await _context.Groups.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<List<Group>> GetAll()
        {
            return await _context.Groups.ToListAsync();
        }

        public async Task Update(Group model)
        {
            var groupToUpdate = await _context.Groups.FirstOrDefaultAsync(x => x.Id == model.Id);

            groupToUpdate.Name = model.Name;
            groupToUpdate.StudentId = model.StudentId;
            groupToUpdate.CourseId = model.CourseId;

            await _context.SaveChangesAsync();
        }
    }
}
