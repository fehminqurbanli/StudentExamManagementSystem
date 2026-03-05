namespace StudentExamDemo.Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte Class { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
