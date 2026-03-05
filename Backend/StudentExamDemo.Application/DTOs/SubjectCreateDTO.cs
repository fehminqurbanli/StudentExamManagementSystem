using System.ComponentModel.DataAnnotations;

namespace StudentExamDemo.Application.DTOs
{
    public class SubjectCreateDTO
    {
        [Required(ErrorMessage = "Kod məcburidir")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Kod maksimum 3 simvol olmalıdır")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Fənn adı məcburidir")]
        [StringLength(30, ErrorMessage = "Fənn adı maksimum 30 simvol ola bilər")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Sinif məcburidir")]
        [Range(1, 11, ErrorMessage = "Sinif 1 ilə 11 arasında olmalıdır")]
        public byte Class { get; set; }
        [Required(ErrorMessage = "Müəllim adı məcburidir")]
        [StringLength(20, ErrorMessage = "Müəllim adı maksimum 20 simvol ola bilər")]
        public string TeacherName { get; set; }

        [Required(ErrorMessage = "Müəllim soyadı məcburidir")]
        [StringLength(20, ErrorMessage = "Müəllim soyadı maksimum 20 simvol ola bilər")]
        public string TeacherSurname { get; set; }
    }
}
