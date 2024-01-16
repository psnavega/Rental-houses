﻿using Microsoft.EntityFrameworkCore;
using immob.Models;

namespace immob.Infra
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=immob;User Id=SA;Password=MyPass@word;Persist Security Info=False;Encrypt=False");

            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}