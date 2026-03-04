using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Infrastructure.Persistence.Configurations
{
    public class StudentExamConfiguration : IEntityTypeConfiguration<StudentExam>
    {
        public void Configure(EntityTypeBuilder<StudentExam> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.ExamId });

            builder.HasOne(x => x.Student)
                .WithMany(x => x.StudentExams)
                .HasForeignKey(x => x.StudentId);

            builder.HasOne(x => x.Exam)
                .WithMany(x => x.StudentExams)
                .HasForeignKey(x => x.ExamId);
        }
    }
}
