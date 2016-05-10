using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using DBLayer;

namespace ControlerLayer
{
    public class ProductCtr
    {
        public void CreatCPU(CPU cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.CPUs.Add(cpu);
                db.SaveChanges();
            }
        }
    }
}
