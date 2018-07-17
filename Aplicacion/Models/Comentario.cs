using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Comentario
    {
        public long ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Texto { get; set; }
        public Administrador Autor { get; set; }
        public Publicacion publicacion { get; set; }       //generalmente no es necesario
    }
}