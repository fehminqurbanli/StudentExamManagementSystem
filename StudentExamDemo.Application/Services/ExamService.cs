using StudentExamDemo.Domain.Entities;
using StudentExamDemo.Domain.Interfaces;
using StudentExamDemo.Domain.Repositories;

namespace StudentExamDemo.Application.Services
{
    public class ExamService: IExamService
    {
        private readonly IExamRepository _repository;

        public ExamService(IExamRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Exam>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Exam?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task AddAsync(Exam exam) => _repository.AddAsync(exam);
        public Task UpdateAsync(Exam exam) => _repository.UpdateAsync(exam);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}
