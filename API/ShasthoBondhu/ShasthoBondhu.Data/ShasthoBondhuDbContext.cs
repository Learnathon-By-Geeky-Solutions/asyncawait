using Microsoft.EntityFrameworkCore;
using ShasthoBondhu.Data.Entities;

namespace ShasthoBondhu.Data
{
    public class ShasthoBondhuDbContext(DbContextOptions options) : DbContext(options), IShasthoBondhuDbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return SaveChangesAsync(new CancellationToken());
        }
    }
}
