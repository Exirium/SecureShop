using System.ComponentModel.DataAnnotations;

namespace SecureShop.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; } = default!;

        [Required]
        public string Subject { get; set; } = default!;

        [Required]
        public string Comment { get; set; } = default!;
    }
}
