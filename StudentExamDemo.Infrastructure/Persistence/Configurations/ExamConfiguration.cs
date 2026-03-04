using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Infrastructure.Persistence.Configurations
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.ToTable("Exams");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ExamDate)
                   .IsRequired();

            builder.Property(e => e.Grade)
                   .HasColumnType("numeric(1,0)")
                   .IsRequired();

            builder.HasCheckConstraint(
                "CK_Exam_Grade",
                "[Grade] BETWEEN 0 AND 9");

            builder.HasOne(e => e.Subject)
                   .WithMany(s => s.Exams)
                   .HasForeignKey(e => e.SubjectId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Student)
                   .WithMany(s => s.Exams)
                   .HasForeignKey(e => e.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
