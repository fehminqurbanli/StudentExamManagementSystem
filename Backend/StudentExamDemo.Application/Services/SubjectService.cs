using StudentExamDemo.Domain.Entities;
using StudentExamDemo.Domain.Interfaces;
using StudentExamDemo.Domain.Repositories;

namespace StudentExamDemo.Application.Services
{
    public class SubjectService: ISubjectService
    {
        private readonly ISubjectRepository _repository;

        public SubjectService(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Subject>> GetAllAsync() => _repository.GetAllAsync();
        public Task<Subject?> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task AddAsync(Subject subject) => _repository.AddAsync(subject);
        public Task UpdateAsync(Subject subject) => _repository.UpdateAsync(subject);
        public Task DeleteAsync(int id) => _repository.DeleteAsync(id);
    }
}
