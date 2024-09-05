using be_dozun_tasks.Configuration;
using be_dozun_tasks.Models;
using be_dozun_tasks.Seeders;
using Microsoft.EntityFrameworkCore;

namespace be_dozun_tasks.Data
{
    public class DztasksDbContext : DbContext
    {
        public DztasksDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DztasksConfiguration());

            modelBuilder.Seed();
        }

        public DbSet<Tasks> Tasks { get; set; }
    }
}
