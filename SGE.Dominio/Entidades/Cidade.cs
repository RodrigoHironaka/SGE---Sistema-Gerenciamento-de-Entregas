using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Entidades
{
    public class Cidade : IEntidade
    {
        public override string ToString()
        {
            return Nome;
        }

        public virtual Int64 Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual String UnidadeFederacao { get; set; }
        public virtual Int32 Cep { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual DateTime? DataGeracao { get; set; }

        public virtual String NomeCompleto
        {
            get
            {
                string uf = string.Empty;
                if (this.UnidadeFederacao != null)
                    uf = this.UnidadeFederacao;
                return String.Format("{0}/{1}", Nome, uf);
            }
        }
    }
}
