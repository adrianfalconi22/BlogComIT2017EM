using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RutinaDelDia()
        {
            return View("/Views/Home/RutinaDelDia.cshtml");
        }

        public ActionResult Rutinas()
        {
            return View("/Views/Home/Rutinas.cshtml");
        }

        public ActionResult Ejercicios()
        {
            return View("/Views/Home/Ejercicios.cshtml");
        }

        public ActionResult Pecho()
        {
            return View("/Views/Home/Pecho.cshtml");
        }

        public ActionResult Contacto()
        {
            return View();
        }
        public ActionResult Consejos()
        {
            return View("/Views/Home/Consejos.cshtml");
        }


        [HttpPost]
        public ActionResult MailContacto(string nombre, string mail, string mensaje)
        {
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
            clienteSmtp.Credentials = new NetworkCredential("testComunidadIt@gmail.com", "test");
            clienteSmtp.EnableSsl = true;

            MailMessage mailAEnviar = new MailMessage();
            mailAEnviar.From = new MailAddress("testComunidadIt@gmail.com", "test comunidad");
            mailAEnviar.To.Add("testComunidadIt@gmail.com");
            mailAEnviar.Subject = " te contactaron del blog";
            mailAEnviar.Body = nombre + "( " + mail + ") te dejo el siguiente mensaje" + mensaje;




            clienteSmtp.Send(mailAEnviar);





            return View("Contacto");
        }
    }
}