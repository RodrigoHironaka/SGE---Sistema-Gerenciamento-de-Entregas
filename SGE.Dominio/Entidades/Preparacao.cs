using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Entidades
{
    public class Preparacao : IEntidade
    {
        public Preparacao()
        {
            PreparacaoSetores = new List<PreparacaoSetores>();
        }
        public virtual Int64 Id { get; set; }
        public virtual DateTime? DataGeracao { get; set; }
        public virtual DateTime? Aproximada { get; set; }
        public virtual DateTime? Finalizado { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual IList<PreparacaoSetores> PreparacaoSetores { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual SituacaoPreparacao SituacaoPreparacao { get; set; }
        public virtual Decimal Total { get; set; }
        public virtual Decimal TrocoPara { get; set; }
        public virtual Decimal Troco { get; set; }
        public virtual Int32 Cupom { get; set; }
        public virtual Int32 Ficha { get; set; }
        public virtual String Observacao { get; set; }
        public virtual Entrega Entrega { get; set; }
        public virtual Devolucao Devolucao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual SituacaoPreparacaoSetores Acougue { get; set; }
        public virtual SituacaoPreparacaoSetores Padaria { get; set; }
        public virtual SituacaoPreparacaoSetores Loja { get; set; }
        public virtual SituacaoPreparacaoSetores Caixa { get; set; }

        public virtual String DadosPreparacao
        {
            get
            {
                return String.Format("{0} - {1} Valor: {2}", Id, Cliente.Nome, Total.ToString("N2"));
            }
        }

    }
}
