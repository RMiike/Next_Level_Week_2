using Microsoft.EntityFrameworkCore;
using NextLevelWeek2.Core.Entities;
using Proffy.Data.Configurations;

namespace NextLevelWeek2.Data.Data
{
    public class ProffyDbContext : DbContext
    {
        public ProffyDbContext(DbContextOptions<ProffyDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMaps).Assembly);
        }
    }
}
