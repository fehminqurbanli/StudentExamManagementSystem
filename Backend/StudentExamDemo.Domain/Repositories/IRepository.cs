using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Domain.Repositories
{
    public interface IRepository<T>
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T student);
        Task UpdateAsync(T student);
        Task DeleteAsync(int id);
    }
}
