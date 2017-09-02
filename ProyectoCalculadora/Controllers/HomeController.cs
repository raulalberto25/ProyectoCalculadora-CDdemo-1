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
            if (model.operacion == "+")
            {
                int resultado = model.numero1 + model.numero2;
                ViewBag.resultado = resultado;
            }
            else
            {
            }

            return View();
        }
    }
}