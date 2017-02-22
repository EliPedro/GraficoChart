using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraficoChart.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico
        public ActionResult ExemploGrafico()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}