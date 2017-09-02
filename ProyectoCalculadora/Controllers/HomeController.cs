using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoCalculadora.Models;

namespace ProyectoCalculadora.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculadoraModel model)
        {
            int resultado = 0;
            ViewBag.resultado = resultado;

            return View();
        }
    }
}