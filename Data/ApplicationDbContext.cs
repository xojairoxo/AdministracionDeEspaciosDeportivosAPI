using Devart.Data.MySql;
using Microsoft.EntityFrameworkCore;
using SportsFacilityManagementAPI.Model;
namespace SportsFacilityManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<EspacioDeportivo> EspacioDeportivo { get; set; }
        public DbSet<Reserva> Reservaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EspacioDeportivo>().HasKey(e => e.EspaciosDeportivosId);
            modelBuilder.Entity<EspacioDeportivo>().ToTable("EspaciosDeportivos");
        }

    }

}
