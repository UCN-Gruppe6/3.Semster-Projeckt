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

        public ActionResult Index(string Manufacturer)
        {
            var Storage = client.FindAllStorage();
            if (!string.IsNullOrEmpty(Manufacturer))
            {
                Storage = client.FindStorageByManufacturer(Manufacturer);
            }
            return View(Storage);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
