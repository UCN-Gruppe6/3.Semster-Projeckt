﻿using MVC_Client.PcPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Client.Controllers
{
    public class BasketController : Controller
    {
        public BasketController()
        {
            // Dette her er en controler!!!
        }

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
                    basket.MyCpu = new CPU { CPUId = id };
                    return RedirectToAction("Index", "CPU");
                    break;
                case "RAM":
                    basket.MyRam = new RAM {  RAMId = id };
                    return RedirectToAction("Index", "RAM");
                    break;
            }
            return RedirectToAction("Index", "Home");
        }
    }
}