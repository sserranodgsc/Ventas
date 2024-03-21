using Microsoft.EntityFrameworkCore;
using Ventas.Shared.Modelos;

namespace Ventas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Canton> Cantones { get; set; }
        public DbSet<Distrito> Distritos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Provincia>().HasIndex(p => p.Nombre).IsUnique();
            modelBuilder.Entity<Canton>().HasIndex("Nombre", "ProvinciaId").IsUnique();
            modelBuilder.Entity<Distrito>().HasIndex("Nombre", "CantonId").IsUnique();
        }
    }
}
