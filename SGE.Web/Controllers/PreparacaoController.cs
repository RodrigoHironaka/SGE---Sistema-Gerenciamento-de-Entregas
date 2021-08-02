using LinqKit;
using SGE.Dominio.Entidades;
using SGE.Repositorio.Repositorios;
using SGE.Web.Utilitarios;
using SGE.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGE.Web.Controllers
{
    public class PreparacaoController : Controller
    {
        #region Repositorio
        private RepositorioPreparacao _repositorio;
        public RepositorioPreparacao Repositorio
        {
            get
            {
                if (_repositorio == null)
                    _repositorio = new RepositorioPreparacao(NHibernateHttpModule.CurrentSession);
                return _repositorio;
            }
            set { _repositorio = value; }
        }
        #endregion

        Preparacao preparacao = new Preparacao();

        // GET: Preparacao
        public ActionResult Index(FiltroPreparacaoVM filtros)
        {
            if (filtros == null)
                filtros = new FiltroPreparacaoVM();
            var predicado = PredicateBuilder.True<Preparacao>();

            predicado = predicado.And(x => x.DataGeracao >= Convert.ToDateTime(filtros.DataInicial));
            predicado = predicado.And(x => x.DataGeracao <= Convert.ToDateTime(filtros.DataFinal).AddHours(23).AddMinutes(59).AddSeconds(59));
            predicado = predicado.And(x => x.SituacaoPreparacao == filtros.Situacao);
            if (!String.IsNullOrEmpty(filtros.Pesquisar))
            {
                string pesquisar = filtros.Pesquisar.ToLower();
                predicado = predicado.And(x => (x.Cliente.Nome.ToLower().Contains(pesquisar) || x.Cliente.Id.ToString().Contains(pesquisar) || x.Id.ToString().Contains(pesquisar)));

            }
            var preparacoes = Repositorio.ObterPorParametros(predicado).ToList();
            filtros.Preparacoes = preparacoes;


            return View(filtros);
        }
    }
}