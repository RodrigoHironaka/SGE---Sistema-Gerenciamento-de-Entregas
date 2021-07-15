using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Dominio.Entidades
{
    public class Devolucao : IEntidade
    {
        public virtual Int64 Id { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual Preparacao Preparacao { get; set; }
        public virtual Motivo Motivo { get; set; }
        public virtual TipoDevolucao TipoDevolucao { get; set; }
        public virtual String NomePessoa { get; set; }
        public virtual Decimal Valor { get; set; }
        public virtual String Observacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual DateTime? DataGeracao { get; set; } //data devolução

    }
}
