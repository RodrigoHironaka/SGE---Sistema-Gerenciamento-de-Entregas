using SGE.Repositorio.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGE.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Entrar", "Login");
            else
                return View();

        }


    }
}