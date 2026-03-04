using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Infrastructure.Persistence.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subjects");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Code)
                   .IsRequired()
                   .HasColumnType("char(3)");

            builder.HasIndex(s => s.Code)
                   .IsUnique();

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(s => s.Class)
                   .HasColumnType("numeric(2,0)")
                   .IsRequired();

            builder.HasCheckConstraint(
                "CK_Subject_Class",
                "[Class] BETWEEN 1 AND 11");

            builder.Property(s => s.TeacherName)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(s => s.TeacherSurname)
                   .IsRequired()
                   .HasMaxLength(20);
        }
    }
}
