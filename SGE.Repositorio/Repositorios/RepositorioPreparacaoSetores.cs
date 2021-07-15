using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioPreparacaoSetores : RepositorioBase<PreparacaoSetores>
    {
        public RepositorioPreparacaoSetores(ISession session) : base(session)
        {

        }
    }
        

}
