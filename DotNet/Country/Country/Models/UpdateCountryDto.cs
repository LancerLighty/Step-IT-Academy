using System.ComponentModel.DataAnnotations;

namespace Country.Models
{
    public class UpdateCountryDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
        [Required]
        [Range(300, int.MaxValue)]
        public int CountryTeritory { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryContinent { get; set; }
        public int LanguageId { get; set; }
    }
}
