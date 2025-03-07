using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task Update(Student entity)
        {
            var entityFromDb = await _context.Students.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb is not null)
            {
                entityFromDb.Name = entity.Name;
                entityFromDb.PersonalNumber = entity.PersonalNumber;
                entityFromDb.Email = entity.Email;
                entityFromDb.BirthDate = entity.BirthDate;
            }
        }
    }
}
