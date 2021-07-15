using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Type;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;

namespace SGE.Repositorio.Mapeamentos
{
    public class CidadeMAP : ClassMapping<Cidade>
    {
        public CidadeMAP()
        {
            Table("cidades");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.Nome);
            Property(x => x.UnidadeFederacao);
            Property(x => x.Cep);
            Property(x => x.Situacao, m => m.Type<EnumType<Situacao>>());
            Property(x => x.DataAlteracao);
            Property(x => x.DataGeracao);
        }
    }
}
