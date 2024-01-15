using Learn1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn1.Persistance
{
    public class Learn1DBContext : DbContext
    {
        public Learn1DBContext(DbContextOptions<Learn1DBContext> options) : base(options)  { 

        }

        // create table
        public DbSet<Product> products { get; set; }
        public DbSet<User> users { get; set; }

        // mapping table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Product Table
            modelBuilder.Entity<Product>()
                .Property(b => b.Id)
                .HasColumnName("id");
            modelBuilder.Entity<Product>()
                .Property(b => b.Name)
                .HasColumnName("name");
            modelBuilder.Entity<Product>()
                .Property(b => b.Category)
                .HasColumnName("category");
            modelBuilder.Entity<Product>()
                .Property(b => b.IsAvailable)
                .HasColumnName("is_available");

            // User Table
            modelBuilder.Entity<User>()
                .Property(b => b.Id)
                .HasColumnName("id");
            modelBuilder.Entity<User>()
                .Property(b => b.Name)
                .HasColumnName("name");
            modelBuilder.Entity<User>()
                .Property(b => b.Email)
                .HasColumnName("email");
            modelBuilder.Entity<User>()
                .Property(b => b.Password)
                .HasColumnName("password");


            base.OnModelCreating(modelBuilder);
        }
    }
}
