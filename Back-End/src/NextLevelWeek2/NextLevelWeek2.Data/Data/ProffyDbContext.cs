using Microsoft.EntityFrameworkCore;
using Proffy.Core.Entities;
using Proffy.Data.Configurations;

namespace NextLevelWeek2.Data.Data
{
    public class ProffyDbContext : DbContext
    {
        public ProffyDbContext(DbContextOptions<ProffyDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<Connection> Connections { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMaps).Assembly);
        }
    }
}
