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
            var connString = "";
            var connStringName = "DB1-ConnectionString";
            var websiteName = "/ProyectoCalculadora";

            System.Configuration.ConnectionStringSettings connStringSetting;
            
            System.Configuration.Configuration rootWebConfig =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(websiteName);
            
            if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
            {
                connStringSetting =
                    rootWebConfig.ConnectionStrings.ConnectionStrings[connStringName];
                if (connStringSetting != null)
                    connString = connStringSetting.ConnectionString;

                ViewBag.connectionString = connString;
            }

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