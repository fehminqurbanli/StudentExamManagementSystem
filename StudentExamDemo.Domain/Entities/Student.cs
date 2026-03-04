namespace StudentExamDemo.Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
    }
}
