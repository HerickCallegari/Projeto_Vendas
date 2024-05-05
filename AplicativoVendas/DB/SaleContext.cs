using AplicativoVendas.Model.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoVendas.DB
    {
    internal class SaleContext : DbContext
        {
        public DbSet<Item> Items { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        public string DbPath { get; }

        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
            {
            optionsBuilder.UseSqlServer ("server=(localdb)\\mssqllocaldb;database=AplicativoVendas;Trusted_Connection=true");
            }
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
            {
            modelBuilder.Entity<Item> ().HasKey (item => item.ItemId);
            }
        }
    }
