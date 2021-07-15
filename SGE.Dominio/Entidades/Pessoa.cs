using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Entidades
{
    public class Pessoa : IEntidade
    {
        public virtual Int64 Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual TipoPessoa TipoPessoa { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual String Endereco { get; set; }
        public virtual String Bairro { get; set; }
        public virtual String Complemento { get; set; }
        public virtual DateTime? Nascimento { get; set; }
        public virtual Int64 Documento { get; set; }
        public virtual String Telefone { get; set; }
        public virtual String Telefone2 { get; set; }
        public virtual String Email { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual DateTime? DataGeracao { get; set; }

        public virtual string DocumentoFormatado
        {
            get
            {
                if (TipoPessoa == ObjetoValor.TipoPessoa.Física)
                    return Documento.ToString(@"000\.000\.000\-00");
                else
                    return Documento.ToString(@"00\.000\.000\/0000\-00");
            }
        }

        
    }
}
