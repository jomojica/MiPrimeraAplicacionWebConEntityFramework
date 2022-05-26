﻿/* Creacion de los controles de MARCA*/
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
            List<MarcaCLS> listaMarca = null;
            using (var bd = new BDPasajeEntities1())
            {
                listaMarca = (from marca in bd.Marca
                              select new MarcaCLS
                              {
                                  iidmarca = marca.IIDMARCA,
                                  nombre = marca.NOMBRE,
                                  descripcion = marca.DESCRIPCION
                              }).ToList();
            }
            return View(listaMarca);
        }
    }
}