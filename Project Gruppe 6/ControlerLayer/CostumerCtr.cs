using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DBLayer;

namespace ControlLayer
{
    public class CustomerCtr
    {
        // Metode til at lave en kunde.
        // Laver en ny db context.
        public void CreatCostumer(Customer costumer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Costumer.Add(costumer);
                db.SaveChanges();
            }
        }

        // Dette er en midligtigt metode til at finde en kunde via navn.
        public IEnumerable<Customer> FindCostumerByName(string name)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Costumer.Where(x => x.Name.Equals(name)).ToList();
            }
        }
    }
}
