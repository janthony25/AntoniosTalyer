using System.ComponentModel.DataAnnotations;

namespace AntoniosTalyer.Models
{
    public class Issue
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Problem { get; set; }
        public string? PartsNeed { get; set; }
        public Decimal? PartsPrice { get; set; }
        public string? Description { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? LaborPrice { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
