using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioColaborador :  RepositorioBase<Colaborador>
    {
        public RepositorioColaborador(ISession session) : base(session)
        {

        }
    }
}
