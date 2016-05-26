using MVC_Client.PcPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

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
            try
            {
                if (HttpContext.Session["basket"] == null)
                {
                    HttpContext.Session["basket"] = new Basket();
                }
                Basket basket = (Basket)HttpContext.Session["basket"];
                switch (type)
                {
                    case "CPU":
                        basket.MyCpu = client.FindCPUbyId(id);
                        return RedirectToAction("Index", "Hardware");
                    case "RAM":
                        basket.MyRam = client.FindRAMbyId(id);
                        return RedirectToAction("Index", "Hardware");
                    case "GPU":
                        basket.MyGpu = client.FindGPUbyId(id);
                        return RedirectToAction("Index", "Hardware");
                    case "Motherboard":
                        basket.MyMotherboard = client.FindMotherbordById(id);
                        return RedirectToAction("Index", "Hardware");
                    case "Computer_Case":
                        basket.MyComputerCase = client.FindCaseById(id);
                        return RedirectToAction("Index", "Hardware");
                    case "Storage":
                        basket.MyStorage = client.FindStorageById(id);
                        return RedirectToAction("Index", "Hardware");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.GetType().ToString() + " " + e.ToString());
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Buy()
        {
            try
            {
                Basket basket = (Basket)HttpContext.Session["basket"];

                if (basket.MyCpu != null)
                {
                    basket.MyCpu.Stock--;
                    client.UpdateCPU(basket.MyCpu);
                }
                if (basket.MyGpu != null)
                {
                    basket.MyGpu.Stock--;
                    client.UpdateGPU(basket.MyGpu);
                }
                if (basket.MyMotherboard != null)
                {
                    basket.MyMotherboard.Stock--;
                    client.UpdateMotherbord(basket.MyMotherboard);
                }
                if (basket.MyStorage != null)
                {
                    basket.MyStorage.Stock--;
                    client.UpdateStorage(basket.MyStorage);
                }
                if (basket.MyRam != null)
                {
                    basket.MyRam.Stock--;
                    client.UpdateRAM(basket.MyRam);
                }
                if (basket.MyComputerCase != null)
                {
                    basket.MyComputerCase.Stock--;
                    client.UpdateComputerCase(basket.MyComputerCase);
                }

                client.CreateBasket(basket);

                HttpContext.Session["basket"] = null;
            }
            catch
            {
                return View("BuyError");
            }

            return View("BuyConformation");
        }
    }
}