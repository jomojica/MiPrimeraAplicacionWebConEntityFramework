﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAplicacionWebConEntityFramework.Models;

namespace MiPrimeraAplicacionWebConEntityFramework.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaCLS> listaMarca = null;
            using(var bd= new BDPasajeEntities())
            {
               listaMarca = (from marca in bd.Marca
                                 select new MarcaCLS
                                    {
                                    iidmarca = marca.IIDMARCA,
                                    nombre = marca.NOMBRE,
                                    descripcion  = marca.DESCRIPCION
                                    }).ToList();
            }
            return View(listaMarca);
        }
    }
}