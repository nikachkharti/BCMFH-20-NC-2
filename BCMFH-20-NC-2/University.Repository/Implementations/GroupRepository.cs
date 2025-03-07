using Microsoft.EntityFrameworkCore;
using University.Models.Entities;
using University.Repository.Data;
using University.Repository.Interfaces;

namespace University.Repository.Implementations
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        private readonly ApplicationDbContext _context;

        public GroupRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task Update(Group entity)
        {
            var entityFromDb = await _context.Groups.FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (entityFromDb is not null)
            {
                entityFromDb.Name = entity.Name;
                entityFromDb.StudentId = entity.StudentId;
                entityFromDb.CourseId = entity.CourseId;
            }
        }
    }
}
