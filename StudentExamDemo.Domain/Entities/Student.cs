using System.ComponentModel.DataAnnotations;

namespace StudentExamDemo.Domain.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string FirstName { get; set; }

        [Required, StringLength(30)]
        public string LastName { get; set; }

        public int Class { get; set; }

        public ICollection<Exam>? Exams { get; set; }
    }
}
