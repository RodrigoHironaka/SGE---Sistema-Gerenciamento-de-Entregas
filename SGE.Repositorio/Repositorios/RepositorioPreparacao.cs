using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioPreparacao : RepositorioBase<Preparacao>
    {
        public RepositorioPreparacao(ISession session) : base(session)
        {

        }
    }
}
