using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Entidades
{
    public class Base  : IEntidade
    {
        public virtual Int64 Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual DateTime? DataGeracao { get; set; }
    }
}
