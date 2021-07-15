using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioCidade : RepositorioBase<Cidade>
    {
        public RepositorioCidade(ISession session) : base(session)
        {

        }
    }
        
}
