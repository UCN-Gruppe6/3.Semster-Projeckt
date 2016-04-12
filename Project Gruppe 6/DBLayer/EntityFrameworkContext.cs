using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.Hardware;

namespace DBLayer
{
    public class EntityFrameworkContext : DbContext
    { 
        EntityFrameworkContext() : base("name=EntityFrameworkContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<CPU> CPUs { get; set; }

    }
}
