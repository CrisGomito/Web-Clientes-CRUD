using Microsoft.EntityFrameworkCore;

namespace Clientes.Models;

public class ClientesDbContext : DbContext
{
    public ClientesDbContext(DbContextOptions<ClientesDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nombre).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Apellido).IsRequired().HasMaxLength(50);
            entity.Property(e => e.DocumentoIdentidad).IsRequired().HasMaxLength(20);
            entity.HasIndex(e => e.DocumentoIdentidad).IsUnique();
            entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Telefono).IsRequired().HasMaxLength(20);
            entity.Property(e => e.Direccion).IsRequired().HasMaxLength(150);
            entity.Property(e => e.Ciudad).IsRequired().HasMaxLength(50);
            entity.Property(e => e.LimiteCredito).HasColumnType("decimal(18,2)");
        });
    }
}
