using Microsoft.EntityFrameworkCore;
using StudentExamDemo.Domain.Entities;
using StudentExamDemo.Domain.Repositories;
using StudentExamDemo.Infrastructure.Persistence;

namespace StudentExamDemo.Infrastructure.Repositories
{
    public class ExamRepository : IExamRepository
    {
        private readonly AppDbContext _context;

        public ExamRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Exam exam)
        {
            await _context.Exams.AddAsync(exam);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var exam = await _context.Exams.FindAsync(id);
            if (exam != null)
            {
                _context.Exams.Remove(exam);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Exam>> GetAllAsync()
        {
            return await _context.Exams.ToListAsync();
        }

        public async Task<Exam?> GetByIdAsync(int id)
        {
            return await _context.Exams.FindAsync(id);
        }

        public async Task UpdateAsync(Exam exam)
        {
            _context.Exams.Update(exam);
            await _context.SaveChangesAsync();
        }
    }
}
