using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SGE.Dominio.Entidades;

namespace SGE.Repositorio.Mapeamentos
{
    public class PreparacaoSetoresMAP : ClassMapping<PreparacaoSetores>
    {
        public PreparacaoSetoresMAP()
        {
            Table("preparacaosetores");
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.Inicio);
            Property(x => x.Final);
            Property(x => x.Tempo);
            Property(x => x.DataAlteracao);
            Property(x => x.DataGeracao);
            ManyToOne(x => x.Setor, m => m.Column("Setor"));
            ManyToOne(x => x.Colaborador, m => m.Column("Colaborador"));
            ManyToOne(x => x.Preparacao, m => m.Column("Preparacao"));
        }
    }
}
