using System.ComponentModel.DataAnnotations;

namespace AntoniosTalyer.Models
{
    public class Issue
    {
        [Key]
        public int IssueId { get; set; }
        public string Problem { get; set; }
        public string PartsNeed { get; set; }
        public string PartsPrice { get; set; }
        public string Description { get; set; }
    }
}
