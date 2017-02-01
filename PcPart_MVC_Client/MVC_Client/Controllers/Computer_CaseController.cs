using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class Computer_CaseController : Controller
    {
        private PcPart.PcPartServiceClient client = new PcPart.PcPartServiceClient();

        public ActionResult Index(string Manufacturer)
        {

            var ComputerCases = client.FindAllComputerCases();

            if (!String.IsNullOrEmpty(Manufacturer))
            {
                ComputerCases = client.FindComputerCaseByManufacturer(Manufacturer);
            }

            return View(ComputerCases);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
