using System.ComponentModel.DataAnnotations;

namespace StudentExamDemo.Application.DTOs
{
    public class StudentCreateDTO
    {
        [Required(ErrorMessage = "Tələbə nömrəsi məcburidir")]
        [Range(0, 99999, ErrorMessage = "Tələbə nömrəsi 0 ilə 99999 arasında olmalıdır")]
        public int StudentNumber { get; set; }
        [Required(ErrorMessage = "Ad məcburidir")]
        [StringLength(30, ErrorMessage = "Ad maksimum 30 simvol ola bilər")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad məcburidir")]
        [StringLength(30, ErrorMessage = "Soyad maksimum 30 simvol ola bilər")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Sinif məcburidir")]
        [Range(1, 11, ErrorMessage = "Sinif 1 ilə 11 arasında olmalıdır")]
        public byte Class { get; set; }
    }
}
