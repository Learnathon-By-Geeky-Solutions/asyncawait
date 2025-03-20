using Microsoft.EntityFrameworkCore;
using ShasthoBondhu.Data.Entities;
using ShasthoBondhu.Data.Entities.AuditLog;

namespace ShasthoBondhu.Data
{
    public class ShasthoBondhuDbContext(DbContextOptions options) : DbContext(options), IShasthoBondhuDbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Receptionist> Receptionists { get; set; }

        public DbSet<Nominee> Nominees { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<DoctorHospital> DoctorHospitals { get; set; }

        public DbSet<DoctorReceptionist> DoctorReceptionists { get; set; }

        public DbSet<DoctorVisitingSchedules> DoctorVisitingSchedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
              .SelectMany(x => x.GetForeignKeys())
              .Where(x => !x.IsOwnership && x.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }

        public Task<int> SaveChangesAsync()
        {
            UpdateAuditFields();
            return SaveChangesAsync(new CancellationToken());
        }

        private void UpdateAuditFields()
        {
            var currentUser = "User #not-implemented"; // Has to be implemented after authentication
            var entries = ChangeTracker.Entries<AuditableEntity>();

            foreach (var entry in entries)
            {
                if (entry?.Entity != null && entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedBy = currentUser;
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                }
                else if (entry?.Entity != null && entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedBy = currentUser;
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
        }
    }
}
