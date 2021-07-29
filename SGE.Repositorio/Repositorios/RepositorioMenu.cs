using NHibernate;
using SGE.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Repositorio.Repositorios
{
    public class RepositorioMenu : RepositorioBase<Menu>
    {
        public RepositorioMenu(ISession session):base(session)
        {

        }
    }
}
