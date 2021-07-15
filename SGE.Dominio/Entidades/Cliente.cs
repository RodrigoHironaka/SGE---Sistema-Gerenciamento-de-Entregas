using SGE.Dominio.Interface;
using System;

namespace SGE.Dominio.Entidades
{
    public class Cliente : Pessoa
    {
        public override string ToString()
        {
            return Nome;
        }

        public virtual String Responsaveis { get; set; }
        public virtual String DadosCliente
        {
            get
            {
                //string nome, endereco, bairro, complemento, telefone, telefone2, responsaveis = string.Empty;
                //if (this.Nome != null) 
                //    uf = this.UnidadeFederacao;
                return String.Format("{0} | End:{1}-{2}-{3} | Tel:{4}-Tel2:{5} | {6}", Nome, Endereco, Bairro, Complemento, Telefone, Telefone2, Responsaveis);
            }
        }
    }
}
