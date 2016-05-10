using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Hardware;
using DBLayer;

namespace ControlerLayer
{
    // Denne her ctr bliver brugt til Create, Update og Delete. 
    public class ProductCtr
    {
        // CPU
        #region

        public void CreatCPU(CPU cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.CPUs.Add(cpu);
                db.SaveChanges();
            }
        }

        public void UpdateCPU(CPU cpu)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(cpu).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteCPU(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                CPU cpu = new CPU();
                cpu.CPUId = id;
                db.Entry(cpu).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        #endregion
    }
}
