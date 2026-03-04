using System.ComponentModel.DataAnnotations;

namespace StudentExamDemo.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Class { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
