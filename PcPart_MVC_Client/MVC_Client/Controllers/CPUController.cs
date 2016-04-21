using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class CPUController : Controller
    {
        private PcPart.PcPartServiseClient client = new PcPart.PcPartServiseClient();

        public ActionResult Index(string brand)
        {
            var CPUs = client.FindAllCPUs();

            if(!String.IsNullOrEmpty(brand))
            {
               CPUs = client.FindCPUsByBrand(brand);
            }

            return View(CPUs);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CPU/Create
        public ActionResult FindCPUsByBrand()
        {
            return View();
        }

        // POST: CPU/Create
        [HttpPost]
        public ActionResult FindCPUsByBrand(FormCollection collection)
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

        // GET: CPU/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CPU/Edit/5
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

        // GET: CPU/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CPU/Delete/5
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
