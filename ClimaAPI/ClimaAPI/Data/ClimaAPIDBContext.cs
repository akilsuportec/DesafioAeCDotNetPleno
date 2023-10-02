using ClimaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClimaAPI.Data
{
    public class ClimaAPIDBContext : DbContext
    {
        public ClimaAPIDBContext(DbContextOptions<ClimaAPIDBContext> options)
        : base(options)
        {
        }

        public DbSet<Clima> Climas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClimaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
