using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public String Index()
        {
            return "Foda-se o hello world, escrevo o que eu quiser";
        }

        // GET: Default
        public String Xablau(string id)
        {
            return "Xablau " + id;
        }

        public String Somar(int? n1, int? n2)
        {
            int? resultado = n1 + n2;
            return "Resultado " + resultado;
        }

        public ActionResult AbrirView()
        {
            return View();
        }

        public ActionResult SomarNumeros(int? n1, int? n2)
        {
            int? resultado = n1 + n2;
            ViewBag.Resultado = resultado;
            return View();
        }
    }
}