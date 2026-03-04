namespace StudentExamDemo.Domain.Entities
{
    public class Exam
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;
        public int MaxScore { get; set; }

        public ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
    }
}
