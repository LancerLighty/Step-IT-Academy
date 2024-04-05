using System.ComponentModel.DataAnnotations;

namespace Country.Models
{
    public class CountryDto
    {
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
        [Required]
        [Range(300, int.MaxValue)]
        public int CountryTeritory { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryContinent { get; set; }
        public string LanguageName { get; set; }
    }
}
