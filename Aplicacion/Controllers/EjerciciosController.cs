using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion.Controllers
{
    public class EjerciciosController : Controller
    {
        // GET: Ejercicios
        public ActionResult Abdomen()
        {
            return View("/Views/Ejercicios/Pecho.cshtml");
        }
        public ActionResult Pecho()
        {
            return View("/Views/Ejercicios/Pecho.cshtml");
        }
        public ActionResult Biceps()
        {
            return View("/Views/Ejercicios/Pecho.cshtml");
        }
        public ActionResult Triceps()
        {
            return View("/Views/Ejercicios/Pecho.cshtml");
        }
             
        public ActionResult Espalda()
        {
            return View("/Views/Ejercicios/Pecho.cshtml");
        }
        public ActionResult Hombros()
        {
            return View("/Views/Ejercicios/Hombros.cshtml");
        }
       
        public ActionResult Piernas()
        {
            return View("/Views/Ejercicios/Pecho.cshtml");
        }

    }
}