using HNClothingShop.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HNClothingShop.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            var prodictosBL = new ProductosBL();
            var listadeProductos = prodictosBL.ObtenerProductos();


            return View(listadeProductos);
        }
    }
}