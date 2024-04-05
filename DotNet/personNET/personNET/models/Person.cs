using System.ComponentModel.DataAnnotations;

namespace personNET.models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [Range(18, 100, ErrorMessage = "Age must be between 18-100")]
        public int Age { get; set; }
        [Required]
        [Range(300, int.MaxValue, ErrorMessage = "Salary must be a positive number")]
        public int Salary { get; set; }
        public Nationality Nationality { get; set; }
        public int NationalityId {  get; set; }
    }
}
