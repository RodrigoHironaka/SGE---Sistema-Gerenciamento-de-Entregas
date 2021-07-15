using SGE.Dominio.Interface;
using SGE.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGE.Dominio.Entidades
{
    public class Entrega : IEntidade
    {
        public virtual Int64 Id { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual Preparacao Preparacao { get; set; }
        public virtual DateTime Saida { get; set; }
        public virtual DateTime Chegada { get; set; }
        public virtual TimeSpan Tempo { get; set; }
        
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual DateTime? DataGeracao { get; set; }

        public virtual String DadosEntrega
        {
            get
            {
                return String.Format("Cod: {0} - {1}| Saída: {2} - Chegada: {3} | Tempo: {4}", Id, Colaborador.Nome, Saida.ToString("HH:mm"), Chegada.ToString("HH:mm"), Tempo.ToString(@"hh\:mm\:ss"));
            }
        }
    }
}
