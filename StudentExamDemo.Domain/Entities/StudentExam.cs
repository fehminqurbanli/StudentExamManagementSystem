namespace StudentExamDemo.Domain.Entities
{
    public class StudentExam
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public Guid ExamId { get; set; }
        public Exam Exam { get; set; } = null!;

        public int Score { get; set; }
    }
}
