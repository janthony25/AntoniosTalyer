using System.ComponentModel.DataAnnotations;

namespace AntoniosTalyer.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CarRego { get; set; }
    }
}
