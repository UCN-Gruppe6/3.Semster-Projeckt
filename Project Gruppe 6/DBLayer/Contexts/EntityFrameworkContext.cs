﻿using System.Data.Entity;
using ModelLayer.Hardware;
using ModelLayer;
using ModelLayer.Basket;

namespace DBLayer
{
    public class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext() : base("name = Kamel")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        // Hardware
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Socket> Sockets { get; set; }
        public DbSet<Computer_Case> CompunterCase { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }

        // Kunde

        public DbSet<Customer> Customer { get; set; }

        //Basket
        //public DbSet<Basket> Basket { get; set; }

        #region TEST
        // Bliver kun brugt til en test.
        public DbSet<CPUTestClase> CPUTestClas { get; set; }
        #endregion
    }
}
