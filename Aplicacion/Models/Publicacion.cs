using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class Publicacion
    {
        public long ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagen { get; set; }
        public Administrador Autor { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}