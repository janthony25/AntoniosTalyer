using System.ComponentModel.DataAnnotations;

namespace AntoniosTalyer.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CarMake { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public string CarRego { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
