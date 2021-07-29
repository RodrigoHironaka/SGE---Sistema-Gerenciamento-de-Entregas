using SGE.Web.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGE.Web.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Menus()
        {
            var menus = Configuracao.Menus;
            return PartialView(menus);
        }
    }
}