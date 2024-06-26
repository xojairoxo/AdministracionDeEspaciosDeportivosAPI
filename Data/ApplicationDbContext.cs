using Devart.Data.MySql;
using Microsoft.EntityFrameworkCore;
using SportsFacilityManagementAPI.Model;
namespace SportsFacilityManagementAPI.Data
{
    public class ApplicationDbContext : DbContext  // En esta clase se realiza toda la conexion con la base de datos
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<EspacioDeportivo> EspacioDeportivo { get; set; }
        public DbSet<Reserva> Reservaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EspacioDeportivo>().HasKey(e => e.EspaciosDeportivosId);
            modelBuilder.Entity<EspacioDeportivo>().ToTable("EspaciosDeportivos");
            modelBuilder.Entity<Reserva>().HasKey(e => e.ReservaId);
            modelBuilder.Entity<Reserva>().ToTable("Reserva");
            modelBuilder.Entity<Reserva>()
                .HasOne<EspacioDeportivo>()
                .WithMany()
                .HasForeignKey(r => r.EspaciosDeportivosId);
        }

    }

}
