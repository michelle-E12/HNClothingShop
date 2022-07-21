﻿using HNClothingShop.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HNClothingShop.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductosActivos();
            ViewBag.adminWebsiteURL = ConfigurationManager.AppSettings["adminWebsiteURL"];

            return View(listadeProductos);
        }
    }
}