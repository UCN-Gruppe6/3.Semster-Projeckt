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

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
