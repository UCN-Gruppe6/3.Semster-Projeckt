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
        public void CreatCostumer(Costumer costumer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Costumer.Add(costumer);
                db.SaveChanges();
            }
        }

        // Metode til at finde alle kunderne.

        public IEnumerable<Costumer> FindAllCustomer()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Customer.ToList();
            }
        }

        // Dette er en midligtigt metode til at finde en kunde via navn.
        public IEnumerable<Costumer> FindCostumerByName(string name)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Customer.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            }
        }

        // Metode til at finde en kunde via id.

        public Customer FindCustomerById(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Customer.Find(id);
            }
        }

        // Metode til at updater en kunde.

        public void UpdateCostumer(Costumer costumer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // Metode til at slætte en kunde via deres id.

        public void DeleteCustomer(int id)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                Costumer customer = new Costumer();
                customer.CostumerId = id;
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
