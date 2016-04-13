using System.Data.Entity;
using ModelLayer.Hardware;

namespace DBLayer
{
    public class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext() : base("name = Kamel")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<CPU> CPUs { get; set; }

    }
}
