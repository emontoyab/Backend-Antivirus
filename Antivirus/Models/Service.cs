using System.ComponentModel.DataAnnotations;

namespace Antivirus.Models
{
    public class Service
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(255)]
        public string? image_url { get; set; }
    }
}