using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class Computer_CaseController : Controller
    {
        private PcPart.PcPartServiseClient client = new PcPart.PcPartServiseClient();
        
        public ActionResult Index(string Manufacturer)
        {

            var ComputerCases = client.FindAllComputerCases();

            if (!String.IsNullOrEmpty(Manufacturer))
            {
                ComputerCases = client.FindComputerCaseByManufacturer(Manufacturer);
            }

            return View(ComputerCases);
        }
        // GET: Computer_Case/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Computer_Case/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Computer_Case/Create
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

        // GET: Computer_Case/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Computer_Case/Edit/5
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

        // GET: Computer_Case/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Computer_Case/Delete/5
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
