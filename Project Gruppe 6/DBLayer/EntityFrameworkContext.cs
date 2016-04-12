using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class EntityFrameworkContext : DbContext
    {
        EntityFrameworkContext()
            : base("name=EntityFrameworkContext")
        {

            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        //public DbSet<CLASS> NAMES { get; set; }

    }
}
