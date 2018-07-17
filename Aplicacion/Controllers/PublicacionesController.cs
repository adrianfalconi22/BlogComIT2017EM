using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion.Controllers
{
    public class PublicacionesController : Controller
    {
        [HttpPost]
        public ActionResult GuardarArticulo(int id, string titulo, string imagen, string texto)
        {
            Publicacion nuevaPublicacion = new Publicacion();
            nuevaPublicacion.ID = id;
            nuevaPublicacion.Titulo = titulo;
            nuevaPublicacion.Imagen = imagen;
            nuevaPublicacion.Texto = texto;

            //Session["Articulo"] = nuevoArticulo;

            List<Publicacion> listaPublicaciones = (List<Publicacion>)Session["Publicaciones"];
            if (listaPublicaciones == null)
            {
                //es el primer artículo
                listaPublicaciones = new List<Publicacion>();
            }
            listaPublicaciones.Add(nuevaPublicacion);
            Session["Publicaciones"] = listaPublicaciones;

            return RedirectToAction("Index", "Home");
        }
    }
}