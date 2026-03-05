namespace StudentExamDemo.Application.DTOs
{
    public class ExamDTO
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public DateTime ExamDate { get; set; }
        public byte Grade { get; set; }
    }
}
