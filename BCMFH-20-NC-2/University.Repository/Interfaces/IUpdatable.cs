namespace University.Repository.Interfaces
{
    public interface IUpdatable<T> where T : class
    {
        Task Update(T entity);
    }
}
