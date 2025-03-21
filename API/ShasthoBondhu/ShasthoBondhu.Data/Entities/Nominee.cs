using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class Nominee : AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        public byte[]? Image { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }

        [Phone]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }
    }
}
