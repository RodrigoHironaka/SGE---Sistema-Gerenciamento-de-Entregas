using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Type;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;

namespace SGE.Repositorio.Mapeamentos
{
    public class PreparacaoMAP : ClassMapping<Preparacao>
    {
        public PreparacaoMAP()
        {
            Table("Preparacoes");
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.DataGeracao);
            Property(x => x.Aproximada);
            Property(x => x.Finalizado);
            Property(x => x.SituacaoPreparacao, m => m.Type<EnumType<SituacaoPreparacao>>());
            Property(x => x.Total);
            Property(x => x.TrocoPara);
            Property(x => x.Troco);
            Property(x => x.Cupom);
            Property(x => x.Ficha);
            Property(x => x.Observacao);
            Property(x => x.DataAlteracao);
            Property(x => x.Acougue, m => m.Type<EnumType<SituacaoPreparacaoSetores>>());
            Property(x => x.Padaria, m => m.Type<EnumType<SituacaoPreparacaoSetores>>());
            Property(x => x.Loja, m => m.Type<EnumType<SituacaoPreparacaoSetores>>());
            Property(x => x.Caixa, m => m.Type<EnumType<SituacaoPreparacaoSetores>>());


            ManyToOne(x => x.Cliente, m => m.Column("Cliente"));
            ManyToOne(x => x.FormaPagamento, m => m.Column("FormaPagamento"));
            ManyToOne(x => x.Entrega, m => m.Column("Entrega"));
            ManyToOne(x => x.Devolucao, m => m.Column("Devolucao"));

            Bag(x => x.PreparacaoSetores, m =>
            {
                m.Cascade(Cascade.All);
                m.Key(k => k.Column("Preparacao"));
                m.Inverse(true);
            }, map => map.OneToMany(a => a.Class(typeof(PreparacaoSetores))));

        }
    }
}
