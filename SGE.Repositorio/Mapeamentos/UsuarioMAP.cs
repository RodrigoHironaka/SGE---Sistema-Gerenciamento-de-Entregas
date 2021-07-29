using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Type;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Repositorio.Mapeamentos
{
    public class UsuarioMAP : ClassMapping<Usuario>
    {
        public UsuarioMAP()
        {
            Table("usuarios");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.Nome);
            Property(x => x.Login);
            Property(x => x.Senha);
            Property(x => x.Situacao, m => m.Type<EnumType<Situacao>>());
            Property(x => x.TipoUsuario, m => m.Type<EnumType<TipoUsuario>>());
            Property(x => x.DataAlteracao);
            Property(x => x.DataGeracao);

            Bag(x => x.Acessos, m =>
            {
                m.Table("usuarioacessos");
                m.Key(k => k.Column("Usuario"));

            }, map => map.ManyToMany(a => { a.Class(typeof(Menu)); a.Column("Menu"); }));
        }
    }
}
