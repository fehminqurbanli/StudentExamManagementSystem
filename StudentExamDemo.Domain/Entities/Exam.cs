using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentExamDemo.Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime ExamDate { get; set; }
        public byte Grade { get; set; }
    }
}
