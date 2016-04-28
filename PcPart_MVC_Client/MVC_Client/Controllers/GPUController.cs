using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class GPUController : Controller
    {
        private PcPart.PcPartServiseClient client = new PcPart.PcPartServiseClient();

        public ActionResult Index(string Manufacturer)
        {

            var GPUs = client.FindAllGpus();

            if (!String.IsNullOrEmpty(Manufacturer))
            {
                GPUs = client.FindGpuByManufacturer(Manufacturer);
            }

            return View(GPUs);
        }

        // GET: GPU/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GPU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GPU/Create
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

        // GET: GPU/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GPU/Edit/5
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

        // GET: GPU/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GPU/Delete/5
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
