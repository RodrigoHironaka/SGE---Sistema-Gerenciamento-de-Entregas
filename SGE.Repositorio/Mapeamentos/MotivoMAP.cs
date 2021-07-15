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
    public class MotivoMAP : ClassMapping<Motivo>
    {
        public MotivoMAP()
        {
            Table("motivos");
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.Nome);
            Property(x => x.Situacao, m => m.Type<EnumType<Situacao>>());
            Property(x => x.DataAlteracao);
            Property(x => x.DataGeracao);
        }   
    }       
}
