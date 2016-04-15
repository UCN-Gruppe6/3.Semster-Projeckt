using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DBLayer;
using ModelLayer.Hardware;

namespace ControlerLayer
{
    public class HardwererCtr
    {
        // CPU START

        public void CreateCPU(CPU cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.CPUs.Add(cpu);
                db.SaveChanges();
            }
        }

        public CPU GetCPUByBrand(string Brand)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {

            }
        }

        public IEnumerable<CPU> GetAllCPUs()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.CPUs.ToList();
            }
        }
    }
}
