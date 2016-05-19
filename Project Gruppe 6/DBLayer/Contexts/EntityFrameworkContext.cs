using System.Data.Entity;
using ModelLayer.Hardware;
using ModelLayer;
using ModelLayer.CartItems;
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
        public DbSet<Computer_Case> CompunterCase { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }

        public DbSet<Socket> Sockets { get; set; }

        // Kunde

        public DbSet<Customer> Customer { get; set; }

        // Bluver brugt til kuvren.
        public DbSet<CPUCartItem> CPUtoBUY { get; set; }
        public DbSet<RAMCartItem> RAMtoBUY { get; set; }
        public DbSet<StorageCartItem> StorageToBUY { get; set; }
        public DbSet<GPUCartItem> GPUtoBUY { get; set; }
        public DbSet<MotherboardCartItem> MotherboardToBUY { get; set; }
        public DbSet<Computer_CaseCartItem> CaseToBUY { get; set; }


        #region TEST
        // Bliver kun brugt til en test.
        public DbSet<CPUTestClase> CPUTestClas { get; set; }
        #endregion
    }
}
