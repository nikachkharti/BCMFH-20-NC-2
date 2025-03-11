using System.Linq.Expressions;

namespace University.Repository.Interfaces
{
    public interface IRepositoryBase<T> : ISavable where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, int pageNumber, int pageSize, string includeProperties = null);
        Task<List<T>> GetAllAsync(int pageNumber, int pageSize, string includeProperties = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter, string includeProperties = null);
        Task AddAsync(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
