using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class MarcaCLS
    {
        internal int iidmarca;
        internal string nombre;
        internal string descripcion;

        [Display(Name ="ID Marca")]
        public int IIDMARCA { get; set; }
        [Display(Name = "Nombre")]
        public string NOMBRE { get; set; }
        [Display(Name = "Descripcion")]
        public string DESCRIPCION { get; set; }
        public Nullable<int> BHABILITADO { get; set; }

    }
}