using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Administrador
    {
        public string Mail { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Imagen { get; set; }

        //diferencia con usuario
    }
}