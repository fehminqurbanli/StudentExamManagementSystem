using System.ComponentModel.DataAnnotations;

namespace StudentExamDemo.Domain.Entities
{
    public class Subject
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(3)]
        public string Code { get; set; }
        public Exam Exam { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        public int Class { get; set; }

        public string? TeacherFirstName { get; set; }
        public string? TeacherLastName { get; set; }

        public ICollection<Exam>? Exams { get; set; }
    }
}
