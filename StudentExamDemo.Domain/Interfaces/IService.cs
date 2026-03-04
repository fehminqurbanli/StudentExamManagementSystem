namespace StudentExamDemo.Domain.Interfaces
{
    public interface IService<T>
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T student);
        Task UpdateAsync(T student);
        Task DeleteAsync(int id);
    }
}
