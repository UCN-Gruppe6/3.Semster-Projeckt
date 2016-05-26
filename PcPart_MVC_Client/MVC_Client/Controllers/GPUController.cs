using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class GPUController : Controller
    {
        private PcPart.PcPartServiceClient client = new PcPart.PcPartServiceClient();

        public ActionResult Index(string Manufacturer)
        {

            var GPUs = client.FindAllGpus();

            if (!String.IsNullOrEmpty(Manufacturer))
            {
                GPUs = client.FindGpuByManufacturer(Manufacturer);
            }

            return View(GPUs);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
