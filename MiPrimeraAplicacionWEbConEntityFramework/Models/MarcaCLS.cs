using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWEbConEntityFramework.Models
{
    public class MarcaCLS
    {
        [Display(Name ="Id Marca")]
        public int iidmarca { get; set; }
        [Display(Name = "Nombre")]
        public int nombre { get; set; }
        [Display(Name = "Descripción")]
        public int descripcion{ get; set; }
        //[Display(Name = "B-Habilitado")]
        public int bhabilitado { get; set; }
    }
}