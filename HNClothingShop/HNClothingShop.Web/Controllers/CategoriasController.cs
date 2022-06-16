using HNClothingShop.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HNClothingShop.Web.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var categoriasBL = new CategoriasBL();
            var listadeCategorias = categoriasBL.ObtenerCategorias();

            return View(listadeCategorias);
        }
    }
}