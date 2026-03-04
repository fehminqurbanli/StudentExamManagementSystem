using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Application.DTOs
{
    public class ExamCreateDTO
    {
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public DateTime ExamDate { get; set; }
        public byte Grade { get; set; }
    }
}
