using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Client.PcPart;

namespace MVC_Client.Controllers
{
    public class CustomerController : Controller
    {
        private PcPartServiseClient client = new PcPartServiseClient();

        public ActionResult Index(string name, int? id)
        {

            if (!String.IsNullOrEmpty(name))
            {
               return View(client.FindCustomerByName(name));
            }
            else if (id != null && id != 0)
            {
                return View(new List<Customer> { client.FindCustomerById(id.Value) } );
            }
            else
            {
                return View(client.FindAllCustomers());
            }
        }

        public ActionResult Details(int id)
        {
            return View(client.FindCustomerById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                client.CreateCustomer(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var customer = client.FindCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            try
            {
                client.UpdateCustomer(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var customer = client.FindCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            try
            {
                client.DeleteCustomer(customer.CustomerId);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
