using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class Receptionist : AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Phone]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }

        #region Navigation properties

        public List<DoctorReceptionist>? DoctorReceptionists { get; set; }

        #endregion
    }
}
