using System.ComponentModel.DataAnnotations;

namespace StudentExamDemo.Domain.Entities
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SubjectCode { get; set; }

        public Subject? Subject { get; set; }

        public int StudentId { get; set; }

        public Student? Student { get; set; }

        public DateTime ExamDate { get; set; }

        [Range(1, 5)]
        public int Grade { get; set; }
    }
}
