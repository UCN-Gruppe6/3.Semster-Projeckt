using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class MotherboardController : Controller
    {
        private PcPart.PcPartServiceClient client = new PcPart.PcPartServiceClient();

        public ActionResult Index(string Manufacturer)
        {

            var Motherboards = client.FindAllMotherboard();

            if (!String.IsNullOrEmpty(Manufacturer))
            {
                Motherboards = client.FindMotherboardByManufacturer(Manufacturer);
            }

            return View(Motherboards);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
