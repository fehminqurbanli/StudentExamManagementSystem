using Microsoft.EntityFrameworkCore;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Exam> Exams => Set<Exam>();
        public DbSet<StudentExam> StudentExams => Set<StudentExam>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
