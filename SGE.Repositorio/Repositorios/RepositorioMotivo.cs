using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioMotivo : RepositorioBase<Motivo>
    {
        public RepositorioMotivo(ISession session) : base(session)
        {

        }
    }
}
