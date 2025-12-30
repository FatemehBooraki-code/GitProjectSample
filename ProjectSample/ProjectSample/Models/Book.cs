using System.ComponentModel.DataAnnotations;

namespace ProjectSample.Models
{
    public class Book
    {
        public int Id { get; set; } // کلید اصلی

        [Required, StringLength(150)]
        public string Title { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string ISBN { get; set; } = string.Empty;

        [Range(1400, 2100)]
        public int PublishYear { get; set; }

        [Required, StringLength(50)]
        public string Category { get; set; } = string.Empty;

        [Range(0, 10000)]
        public int AvailableCount { get; set; }
    }
}
