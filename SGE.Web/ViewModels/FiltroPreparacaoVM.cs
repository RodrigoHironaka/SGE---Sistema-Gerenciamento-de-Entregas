using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGE.Web.ViewModels
{
    public class FiltroPreparacaoVM
    {
        public FiltroPreparacaoVM()
        {
            DataInicial = DateTime.Now.ToString("yyyy-MM-dd");
            DataFinal = DateTime.Now.ToString("yyyy-MM-dd"); 
            Situacao = SituacaoPreparacao.Pendente;
            Preparacoes = new List<Preparacao>();
        }
        public String DataInicial { get; set; }
        public String DataFinal { get; set; }
        public SituacaoPreparacao Situacao { get; set; }
        public String Pesquisar { get; set; }
        public IList<Preparacao> Preparacoes { get; set; }
    }
}