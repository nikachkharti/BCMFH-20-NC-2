using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;

        public TeacherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Teacher model)
        {
            await _context.Teachers.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var teacherToDelete = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            _context.Teachers.Remove(teacherToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Teacher> Get(int id)
        {
            var result = await _context.Teachers
                .Include(x => x.Courses)
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<List<Teacher>> GetAll()
        {
            return await _context.Teachers
                .Include(x => x.Courses)
                .ToListAsync();
        }

        public async Task Update(Teacher model)
        {
            var teacherToUpdate = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == model.Id);

            teacherToUpdate.Name = model.Name;

            await _context.SaveChangesAsync();
        }
    }
}
