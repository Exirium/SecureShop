using System.ComponentModel.DataAnnotations;

namespace SecureShop.Models
{
    public class FeedbackViewModel
    {
        [Required]
        public string Subject { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Comment { get; set; } = string.Empty;
    }
}
