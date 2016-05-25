using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class CPUController : Controller
    {
        private PcPart.PcPartServiceClient client = new PcPart.PcPartServiceClient();

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
    }
}
