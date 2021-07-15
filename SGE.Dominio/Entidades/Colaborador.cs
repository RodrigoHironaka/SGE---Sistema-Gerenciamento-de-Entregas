using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Entidades
{
    public class Colaborador : Pessoa
    {
        public override string ToString()
        {
            return Nome;
        }

        public virtual Setor Setor { get; set; }
        public virtual DateTime? Admissao { get; set; }
        public virtual DateTime? Demissao { get; set; }

        public virtual String DadosColaboradorSetor
        {
            get
            {
              return String.Format("{0} - Setor: {1}", Nome, Setor != null ? Setor.Nome : "Setor não definido");

            }
        }
    }
}
