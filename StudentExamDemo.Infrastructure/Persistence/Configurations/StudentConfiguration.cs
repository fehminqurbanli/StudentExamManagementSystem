using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Infrastructure.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.StudentNumber)
                   .HasColumnType("numeric(5,0)")
                   .IsRequired();

            builder.HasIndex(s => s.StudentNumber)
                   .IsUnique();

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(s => s.Surname)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(s => s.Class)
                   .HasColumnType("numeric(2,0)")
                   .IsRequired();

            builder.HasCheckConstraint(
                "CK_Student_Class",
                "[Class] BETWEEN 1 AND 11");
        }
    }
}
