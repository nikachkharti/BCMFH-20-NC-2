using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Student model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var studentToDelete = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            _context.Students.Remove(studentToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> Get(int id)
        {
            var result = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<List<Student>> GetAll()
        {
            var result = await _context.Students.ToListAsync();
            return result;
        }

        public async Task Update(Student model)
        {
            var studentToUpdate = await _context.Students.FirstOrDefaultAsync(x => x.Id == model.Id);

            studentToUpdate.Name = model.Name;
            studentToUpdate.PersonalNumber = model.PersonalNumber;
            studentToUpdate.Email = model.Email;
            studentToUpdate.BirthDate = model.BirthDate;

            await _context.SaveChangesAsync();
        }
    }
}
