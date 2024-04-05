using System.ComponentModel.DataAnnotations;

namespace personNET.models
{
    public class CreatePersonDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName {  get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [Range(18, 100, ErrorMessage = "Age must be between 18-100")]
        public int Age { get; set; }
        [Required]
        [Range(300, int.MaxValue, ErrorMessage = "Salary must be a positive number")]
        public int Salery {  get; set; }
        public int NationalityId {  get; set; }
    }
}
