using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class RegistrationModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Phone]
        public string? Phone { get; set; }

        [Required]
        public string EventTitle { get; set; } = string.Empty;

        public bool IsPresent { get; set; }
    }
}
