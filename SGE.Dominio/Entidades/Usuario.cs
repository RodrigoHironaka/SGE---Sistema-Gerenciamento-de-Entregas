using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Dominio.Entidades
{
    public class Usuario : IEntidade
    {
        public override string ToString()
        {
            return Nome;
        }

        public virtual Int64 Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Login { get; set; }
        public virtual String Senha { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual DateTime? DataGeracao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }

        public virtual IList<Menu> Acessos { get; set; }
    }
}
