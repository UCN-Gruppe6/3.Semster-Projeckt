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

        // Metode der checkker om kurven er ok
        // Hvis den ikke er ok er det forde en anden har nået at købe den vare du havde i en kurv.
        private Boolean CheckBasket()
        {
            bool isBasketOk = true;

            Basket basket = (Basket)HttpContext.Session["basket"];

            if (basket.MyCpu != null)
            {
                if (client.FindCPUbyId(basket.MyCpu.CPUId).Stock < 1)
                {
                    isBasketOk = false;
                }
            }
            if (basket.MyGpu != null)
            {
                if (client.FindGPUbyId(basket.MyGpu.GPUId).Stock < 1)
                {
                    isBasketOk = false;
                }
            }
            if (basket.MyRam != null)
            {
                if (client.FindRAMbyId(basket.MyRam.RAMId).Stock < 1)
                {
                    isBasketOk = false;
                }
            }
            if (basket.MyStorage != null)
            {
                if (client.FindStorageById(basket.MyStorage.StorageId).Stock < 1)
                {
                    isBasketOk = false;
                }
            }
            if(basket.MyMotherboard != null)
            {
                if(client.FindMotherbordById(basket.MyMotherboard.MotherboardId).Stock < 1)
                {
                    isBasketOk = false;
                }
            }
            if(basket.MyComputerCase != null)
            {
                if(client.FindCaseById(basket.MyComputerCase.CaseId).Stock <1)
                {
                    isBasketOk = false;
                }
            }
            return isBasketOk;
        }

        // Tager din kurv og trekker 1 fra i stock fra alle vare i kurven og køber dem.
        private void Buy()
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

                HttpContext.Session["basket"] = null; // Sletter din session
            }
            catch
            {
                View("GeneralError");
            }
        }

        // Checkout metode der ferdigøre dit køb
        public ActionResult CheckOut()
        {
            try
            {
                if (CheckBasket())
                {
                    Buy();
                }
                else
                {
                    return View("BuyError");
                }
            }
            catch
            {
                return View("GeneralError");
            }

            return View("BuyConformation");
        }

        // Regninger din total pris for de vare der er i kurven
        private double TotalSum(double totalPrice)
        {
            Basket basket = (Basket)HttpContext.Session["basket"];

            if (basket != null)
            {
                totalPrice = 0;
                if (basket.MyCpu != null)
                {
                    totalPrice += basket.MyCpu.Price;
                }
                if (basket.MyGpu != null)
                {
                    totalPrice += basket.MyGpu.Price;
                }
                if(basket.MyRam != null)
                {
                    totalPrice += basket.MyRam.Price;
                }
                if(basket.MyStorage != null)
                {
                    totalPrice += basket.MyStorage.Price;
                }
                if (basket.MyMotherboard != null)
                {
                    totalPrice += basket.MyMotherboard.Price;
                }
                if(basket.MyComputerCase != null)
                {
                    totalPrice += basket.MyComputerCase.Price;
                } 
            }
            return totalPrice;
        }
    }
}