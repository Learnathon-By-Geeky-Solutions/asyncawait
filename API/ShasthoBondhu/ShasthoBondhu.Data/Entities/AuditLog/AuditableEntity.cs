namespace ShasthoBondhu.Data.Entities.AuditLog
{
    public abstract class AuditableEntity : Audit
    {
        public int Id { get; set; }
    }
}
