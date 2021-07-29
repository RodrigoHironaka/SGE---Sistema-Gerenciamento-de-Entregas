using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Dominio.Entidades
{
    public class Menu : IEntidade
    {
        public virtual Int64 Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Link { get; set; }
        public virtual Menu MenuPai { get; set; }
        public virtual DateTime? DataGeracao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual IList<Menu> Items { get; set; }

    }
}
