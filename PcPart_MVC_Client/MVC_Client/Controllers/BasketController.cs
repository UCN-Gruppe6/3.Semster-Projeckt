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
            double sum = TotalSum();
            ViewBag.Sum = sum;
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
                    case "Customer":
                        basket.MyCustomer = client.FindCustomerById(id);
                        return RedirectToAction("Index", "Basket");

                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.GetType().ToString() + " " + e.ToString());
            }
            return RedirectToAction("Index", "Home");
        }

        // Checkout metode der ferdigøre dit køb
        public ActionResult CheckOut()
        {
            Basket basket = (Basket)HttpContext.Session["basket"];
            try
            {
                client.Buy(basket);
                HttpContext.Session["basket"] = null;
            }
            catch
            {
                return View("BuyError");
            }

            return View("BuyConformation");
        }

        // Regninger din total pris for de vare der er i kurven
        private double TotalSum()
        {
            Basket basket = (Basket)HttpContext.Session["basket"];
            double totalPrice = 0;
            if (basket != null)
            {
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