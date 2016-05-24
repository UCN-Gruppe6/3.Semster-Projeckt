using MVC_Client.PcPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class BasketController : Controller
    {

        private PcPartServiceClient client = new PcPartServiceClient();

        public ActionResult Index()
        {
            return View();
        }

        // Laver en session som holder bå kurven inden at den bliver gemt.
        // Ligger en vare i kurven.
        public ActionResult AddToBasket(int id, string type)
        {
            if (HttpContext.Session["basket"] == null)
            {
                HttpContext.Session["basket"] = new Basket();
            }
            Basket basket = (Basket)HttpContext.Session["basket"];
            switch (type)
            {
                case "CPU":
                    if(basket.MyCpu == null)
                    {
                        basket.MyCpu = new CPU { CPUId = id };
                        return RedirectToAction("Index", "CPU");
                    }
                    if(basket.MyCpu != null)
                    {
                        return View("BasketError");
                    }
                    break;
                case "RAM":
                    if(basket.MyRam == null)
                    {
                        basket.MyRam = new RAM { RAMId = id };
                        return RedirectToAction("Index", "RAM");
                    }
                    if(basket.MyRam != null)
                    {
                        return View("BasketError");
                    }
                    break;
                case "GPU":
                    if(basket.MyGpu == null)
                    {
                        basket.MyGpu = new GPU { GPUId = id };
                        return RedirectToAction("Index", "GPU");
                    }
                    if(basket.MyGpu != null)
                    {
                        return View("BasketError");
                    }
                    break;
                case "Motherboard":
                    if(basket.MyMotherboard == null)
                    {
                        basket.MyMotherboard = new Motherboard { MotherboardId = id };
                        return RedirectToAction("Index", "Motherboard");
                    }
                    break; 
                    if(basket.MyMotherboard != null)
                    {
                        return View("BasketError");
                    }
                case "Computer_Case":
                    if(basket.MyComputerCase == null)
                    {
                        basket.MyComputerCase = new Computer_Case { CaseId = id };
                        return RedirectToAction("Index", "Computer_Case");

                    }
                    if(basket.MyComputerCase != null)
                    {
                        return View("BasketError");
                    }
                    break;
                case "Storage":
                    if(basket.MyStorage == null)
                    {
                        basket.MyStorage = new Storage { StorageId = id };
                        return RedirectToAction("Index", "Storage");
                    }
                    if(basket.MyStorage != null)
                    {
                        return View("BasketError");
                    }
                    break;
            }
            return RedirectToAction("Index", "Home");
        }
    }
}