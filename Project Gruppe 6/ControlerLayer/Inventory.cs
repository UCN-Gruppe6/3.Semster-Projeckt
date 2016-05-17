using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.Hardware;
using DBLayer;


namespace ControlerLayer
{
    // Bliver ikke brugt til någet.
    // TEST
    public class Inventory
    {
        public CPU FindCpu(string modelNumber)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                var CPU = db.CPUs.Where(x => x.ModelNumber == modelNumber).FirstOrDefault();
                return CPU;
            }
        }

        public void StockCpuADD(CPU CPU, int numberToAdd)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                CPU.Stock = CPU.Stock + numberToAdd;
                db.Entry(CPU).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
