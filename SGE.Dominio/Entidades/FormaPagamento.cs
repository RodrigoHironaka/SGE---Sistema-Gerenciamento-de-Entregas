using SGE.Dominio.ObjetoValor;
using System;

namespace SGE.Dominio.Entidades
{
    public class FormaPagamento : Base
    {
        public override string ToString()
        {
            return Id +"-"+ Nome;
        }
    }
}
