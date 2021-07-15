using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Type;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;

namespace SGE.Repositorio.Mapeamentos
{
    public class EntregaMAP : ClassMapping<Entrega>
    {
        public EntregaMAP()
        {
            Table("entregas");
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.Saida);
            Property(x => x.Chegada);
            Property(x => x.Tempo);
            Property(x => x.DataAlteracao);
            Property(x => x.DataGeracao);
            ManyToOne(x => x.Colaborador, m => m.Column("Colaborador"));
            ManyToOne(x => x.Preparacao, m => m.Column("Preparacao"));

        }
    }
}
