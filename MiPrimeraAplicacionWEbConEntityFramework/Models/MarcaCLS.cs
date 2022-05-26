/* Este es el modelo de Marca Table*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWEbConEntityFramework.Models
{
    public class MarcaCLS
    {/*Este es el modelo marca que solo describe las colummnas de la tabla marca de la base de datos*/
        [Display(Name ="Id Marca")]
        public int iidmarca { get; set; }
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Display(Name = "Descripción")]
        public string descripcion{ get; set; }
        //[Display(Name = "B-Habilitado")]
        public int bhabilitado { get; set; }
    }
}