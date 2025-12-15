using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;

        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;
    }
}
