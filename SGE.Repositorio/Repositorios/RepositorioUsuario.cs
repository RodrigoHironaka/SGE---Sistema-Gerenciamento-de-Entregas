using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioUsuario : RepositorioBase<Usuario>
    {
        public RepositorioUsuario(ISession session) : base(session)
        {

        }
    }
}
