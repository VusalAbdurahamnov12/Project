using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [MaxLength(25), Required]
        public string ContactNumber { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [MinLength(15), MaxLength(500), Required]
        public string Message { get; set; }
        public bool IsViewed { get; set; }
    }
}
