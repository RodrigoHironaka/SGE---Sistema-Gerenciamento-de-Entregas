using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Repositorio.Repositorios
{
     public class RepositorioFormaPagamento : RepositorioBase<FormaPagamento>
    {
        public RepositorioFormaPagamento(ISession session) : base(session)
        {

        }
    }
}
