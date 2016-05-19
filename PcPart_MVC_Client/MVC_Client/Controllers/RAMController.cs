using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class RAMController : Controller     
    {
        private PcPart.PcPartServiceClient client = new PcPart.PcPartServiceClient();

        public ActionResult Index(string Manufacturer)
        {
            
                var RAMs = client.FindAllRam();

                if (!String.IsNullOrEmpty(Manufacturer))
                {
                RAMs = client.FindRamByManufacturer(Manufacturer);
                }

                return View(RAMs);
            }
        
        // GET: RAM/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RAM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RAM/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RAM/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RAM/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RAM/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RAM/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
