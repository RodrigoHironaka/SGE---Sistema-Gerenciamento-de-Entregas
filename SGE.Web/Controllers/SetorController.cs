using SGE.Repositorio.Repositorios;
using SGE.Web.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGE.Web.Controllers
{
    public class SetorController : Controller
    {
        #region Repositorio
        private RepositorioSetor _repositorio;
        public RepositorioSetor Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioSetor(NHibernateHttpModule.CurrentSession);

                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion

        // GET: Setor
        public ActionResult Index()
        {
            var setores = Repositorio.ObterTodos().ToList();
            return View(setores);
        }
    }
}