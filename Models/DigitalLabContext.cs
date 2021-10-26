using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLabApp.Models
{
    public class DigitalLabContext : DbContext
    {
        public DigitalLabContext(DbContextOptions<DigitalLabContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Item>().HasIndex(i => i.Name).IsUnique();
            modelBuilder.Entity<Item>().HasIndex(j => j.Code).IsUnique();
        }
    }
}
