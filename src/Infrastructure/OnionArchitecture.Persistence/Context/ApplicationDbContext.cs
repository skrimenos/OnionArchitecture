﻿using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 100, CreateDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Paper A4", Value = 1, Quantity = 200, CreateDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Book", Value = 300, Quantity = 500, CreateDate = DateTime.Now }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
