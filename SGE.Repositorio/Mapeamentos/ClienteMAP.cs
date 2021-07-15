using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Type;
using SGE.Dominio.Entidades;
using SGE.Dominio.ObjetoValor;

namespace SGE.Repositorio.Mapeamentos
{
    public class ClienteMAP : ClassMapping<Cliente>
    {
        public ClienteMAP()
        {
            Table("clientes");
            Id(x => x.Id, m =>
            {
                m.Generator(Generators.HighLow, g => g.Params(new { max_lo = 0 }));
            });
            Property(x => x.Nome);
            Property(x => x.TipoPessoa, m => m.Type<EnumType<TipoPessoa>>());
            Property(x => x.Endereco);
            Property(x => x.Bairro);
            Property(x => x.Complemento);
            Property(x => x.Nascimento);
            Property(x => x.Documento);
            Property(x => x.Telefone);
            Property(x => x.Telefone2);
            Property(x => x.Email);
            Property(x => x.Responsaveis);
            Property(x => x.Situacao, m => m.Type<EnumType<Situacao>>());
            Property(x => x.DataAlteracao);
            Property(x => x.DataGeracao);
            ManyToOne(x => x.Cidade, m => m.Column("Cidade"));
        }
    }
}
