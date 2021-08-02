using SGE.Dominio.Entidades;
using SGE.Repositorio.Repositorios;
using SGE.Web.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGE.Web.Controllers
{
    [Authorize(Roles = "Administrador")]
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

        Setor setor = new Setor();

        // GET: Setor
        public ActionResult Index()
        {
            var setores = Repositorio.ObterTodos().ToList();
            return View(setores);
        }

        public ActionResult Editar(Int64 id = 0)
        {
            if(id > 0)
            {
                setor = Repositorio.ObterPorId(id);
            }
            return View(setor);
        }

        [HttpPost]
        public ActionResult Editar(Setor setorVM)
        {
            if (String.IsNullOrEmpty(setorVM.Nome))
                ModelState.AddModelError("Nome", "Nome obrigatorio!");
            if (ModelState.IsValid)
            {
                if (setorVM.Id > 0)
                {
                    setor = Repositorio.ObterPorId(setorVM.Id);
                }
                setor.Nome = setorVM.Nome;
                setor.Situacao = setorVM.Situacao;
                if (setorVM.Id == 0)
                    Repositorio.Salvar(setor);
                else
                    Repositorio.Alterar(setor);
                return RedirectToAction("Index");
            }
            
            return View(setor);
        }

        public ActionResult Excluir(Int64 id)
        {
            if(id > 0)
            {
                setor = Repositorio.ObterPorId(id);
                Repositorio.Excluir(setor);
            }
            return RedirectToAction("Index");
        }

    }
}