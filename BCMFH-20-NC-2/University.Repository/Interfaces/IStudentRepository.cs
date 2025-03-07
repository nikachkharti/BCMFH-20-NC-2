using University.Models.Entities;

namespace University.Repository.Interfaces
{
    public interface IStudentRepository : IRepositoryBase<Student>, IUpdatable<Student>
    {
    }
}
