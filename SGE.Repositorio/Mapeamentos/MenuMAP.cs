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
    public class MenuMAP : ClassMapping<Menu>
    {
        public MenuMAP()
        {
            Table("Menus");
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.Nome, m=> m.Length(100));
            Property(x => x.Link);
            ManyToOne(x => x.MenuPai);
            Property(x => x.DataGeracao);
            Property(x => x.DataAlteracao);
            Property(x => x.Situacao, m => m.Type<EnumType<Situacao>>());

            Bag(x => x.Items, m => {
                m.Cascade(Cascade.None);
                m.Key(k => k.Column(col => col.Name("MenuPai")));
                m.Inverse(true);

            }, map => map.OneToMany());
        }
    }
}
