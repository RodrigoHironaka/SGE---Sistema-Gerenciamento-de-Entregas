using SGE.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Entidades
{
    public class PreparacaoSetores : IEntidade
    {
        public virtual Int64 Id { get; set; }
        public virtual Setor Setor { get; set; }
        public virtual DateTime Inicio { get; set; }
        public virtual DateTime Final { get; set; }
        public virtual TimeSpan Tempo { get; set; }
        public virtual DateTime? DataGeracao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual Preparacao Preparacao { get; set; }

    }
}
