using System.ComponentModel.DataAnnotations;

namespace StudentExamDemo.Application.DTOs
{
    public class ExamCreateDTO
    {
        [Required(ErrorMessage = "Fənn məcburidir")]
        [Range(1, int.MaxValue, ErrorMessage = "Fənn seçilməlidir")]
        public int SubjectId { get; set; }
        [Required(ErrorMessage = "Tələbə məcburidir")]
        [Range(1, int.MaxValue, ErrorMessage = "Tələbə seçilməlidir")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "İmtahan tarixi məcburidir")]
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }
        [Required(ErrorMessage = "Qiymət məcburidir")]
        [Range(0, 9, ErrorMessage = "Qiymət 0 ilə 9 arasında olmalıdır")]
        public byte Grade { get; set; }
    }
}
