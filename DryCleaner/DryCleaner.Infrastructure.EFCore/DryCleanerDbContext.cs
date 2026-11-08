using Microsoft.EntityFrameworkCore;

using DryCleaner.Domain.Entities;
using DryCleaner.Domain.Data;

namespace DryCleaner.Infrastructure.EFCore;

/// <summary>
/// Класс описывающий контекст базы данных.
/// </summary>
/// <param name="options">Настройки контекста базы данных</param>
public class DryCleanerDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }

    public DbSet<ProductCategory> ProductCategories { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(builder =>
        {
            builder.HasKey(s => s.Id);

            builder.HasData(DataSeed.Clients);
        });

        modelBuilder.Entity<ProductCategory>(builder =>
        {
            builder.HasKey(pc => pc.Id);

            builder.HasData(DataSeed.Categories);
        });

        modelBuilder.Entity<Product>(builder =>
        {
            builder.HasOne(c => c.Category);

            builder.HasKey(p => p.Id);

            builder.HasData(DataSeed.Products);
        });

        modelBuilder.Entity<Order>(builder =>
        {
            builder.HasOne(o => o.Client)
            .WithMany()
            .IsRequired();

            builder.HasOne(o => o.Product)
            .WithMany()
            .IsRequired();

            builder.HasKey(o => o.Id);

            builder.HasData(DataSeed.Orders);
        });
    }
}
