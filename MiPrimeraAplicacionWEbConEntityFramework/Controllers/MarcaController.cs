using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAplicacionWEbConEntityFramework.Models;

namespace MiPrimeraAplicacionWEbConEntityFramework.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            using (var bd = new BDPasajeEntities())
            {

            }

                return View();
        }
    }
}