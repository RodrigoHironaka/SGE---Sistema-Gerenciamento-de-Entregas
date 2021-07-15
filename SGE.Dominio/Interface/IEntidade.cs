using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Interface
{
    public interface IEntidade
    {
        Int64 Id { get; set; }
        //Situacao Situacao { get; set; }
        DateTime? DataAlteracao { get; set; }
        DateTime? DataGeracao { get; set; }
    }
}
