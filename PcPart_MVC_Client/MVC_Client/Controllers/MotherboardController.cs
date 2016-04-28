using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class MotherboardController : Controller
    {
        private PcPart.PcPartServiseClient client = new PcPart.PcPartServiseClient();

        public ActionResult Index(string Manufacturer)
        {

            var Motherboards = client.FindAllMotherboard();

            if (!String.IsNullOrEmpty(Manufacturer))
            {
                Motherboards = client.FindMotherboardByManufacturer(Manufacturer);
            }

            return View(Motherboards);
        }

        // GET: Motherboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Motherboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motherboard/Create
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

        // GET: Motherboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Motherboard/Edit/5
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

        // GET: Motherboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Motherboard/Delete/5
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
