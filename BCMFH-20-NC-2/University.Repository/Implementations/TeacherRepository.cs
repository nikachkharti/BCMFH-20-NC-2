using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        private readonly ApplicationDbContext _context;
        public TeacherRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task Update(Teacher entity)
        {
            var entityFromDb = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb is not null)
            {
                entityFromDb.Name = entity.Name;
            }
        }
    }
}
