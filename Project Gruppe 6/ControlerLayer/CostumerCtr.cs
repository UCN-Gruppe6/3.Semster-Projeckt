using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace ControlerLayer
{
    public class CustomerCtr
    {
        // Metode til at lave en kunde.
        // Laver en ny db context.
        public void CreateCustomer(Customer customer)
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                db.Customer.Add(customer);
                db.SaveChanges();
            }
        }

        // Metode til at finde alle kunderne.

        public IEnumerable<Customer> FindAllCustomers()
        {
            using (EntityFrameworkContext db = new EntityFrameworkContext())
            {
                return db.Customer.ToList();
            }
        }

        // Dette er en midligtigt metode til at finde en kunde via navn.
        public IEnumerable<Customer> FindCustomerByName(string name)
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

        public void UpdateCustomer(Customer customer)
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
                Customer customer = new Customer();
                customer.CustomerId = id;
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
