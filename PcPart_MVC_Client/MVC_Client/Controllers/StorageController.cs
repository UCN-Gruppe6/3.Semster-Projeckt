using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class StorageController : Controller
    {
        private PcPart.PcPartServiceClient client = new PcPart.PcPartServiceClient();
        // GET: Storage
        public ActionResult Index(string Manufacturer)
        {
            var Storage = client.FindAllStorage();
            if (!string.IsNullOrEmpty(Manufacturer))
            {
                Storage = client.FindStorageByManufacturer(Manufacturer);
            }
            return View(Storage);
        }

        // GET: Storage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Storage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Storage/Create
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

        // GET: Storage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Storage/Edit/5
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

        // GET: Storage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Storage/Delete/5
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
