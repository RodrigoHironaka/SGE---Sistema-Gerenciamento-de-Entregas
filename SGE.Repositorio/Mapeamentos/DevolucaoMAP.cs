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
    public class DevolucaoMAP : ClassMapping<Devolucao>
    {
        public DevolucaoMAP()
        {
            Table("devolucoes");
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.NomePessoa);
            Property(x => x.Valor);
            Property(x => x.Observacao);
            Property(x => x.DataAlteracao);
            Property(x => x.DataGeracao);
            Property(x => x.TipoDevolucao, m => m.Type<EnumType<TipoDevolucao>>());
            ManyToOne(x => x.Colaborador, m => m.Column("Colaborador"));
            ManyToOne(x => x.Preparacao, m => m.Column("Preparacao"));
            ManyToOne(x => x.Motivo, m => m.Column("Motivo"));
        }
    }
}
