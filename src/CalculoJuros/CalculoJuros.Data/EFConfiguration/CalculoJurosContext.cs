using CalculoJuros.Data.EFConfiguration.Mappings;
using CalculoJuros.Domain.Usuarios.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoJuros.Data.EFConfiguration
{
    public class CalculoJurosContext : DbContext
    {
        public CalculoJurosContext(DbContextOptions<CalculoJurosContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}