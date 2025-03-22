using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class Patient : AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public required string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public required DateOnly DateOfBirth { get; set; }

        public byte[]? Image { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }

        [Phone]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(255)]
        public string? InsuranceDetails { get; set; }

        #region Navigation properties

        public List<Appointment>? Appointments { get; set; }

        public List<Nominee>? Nominees { get; set; }

        #endregion
    }
}
