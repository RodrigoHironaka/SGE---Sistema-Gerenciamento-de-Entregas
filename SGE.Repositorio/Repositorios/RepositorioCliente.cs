using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioCliente : RepositorioBase<Cliente>
    {
        public RepositorioCliente(ISession session) : base(session)
        {

        }
    }
}
