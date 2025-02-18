using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Course model)
        {
            await _context.Courses.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var courseToDelete = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
            _context.Courses.Remove(courseToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Course> Get(int id)
        {
            var result = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<List<Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task Update(Course model)
        {
            var courseToUpdate = await _context.Courses.FirstOrDefaultAsync(x => x.Id == model.Id);

            courseToUpdate.Title = model.Title;
            courseToUpdate.TeacherId = model.TeacherId;

            await _context.SaveChangesAsync();
        }
    }
}
