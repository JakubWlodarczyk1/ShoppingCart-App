using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StoreCartWinForms.Model
{
    public class StoreDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=StoreOrdersDb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(eb =>
            {
                eb.Property(x => x.Name).HasMaxLength(50);
                eb.Property(x => x.Surname).HasMaxLength(50);
                eb.Property(x => x.DateOfBirth).HasColumnType("datetime2").HasPrecision(0);
                eb.HasMany(w => w.Products)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId);
            });
            modelBuilder.Entity<Product>(eb =>
            {
                eb.Property(x => x.Price).HasPrecision(7,2);
                eb.Property(x => x.Quanity).HasDefaultValue(1);
                eb.Property(x => x.ProductName).HasMaxLength(100);
            });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}

