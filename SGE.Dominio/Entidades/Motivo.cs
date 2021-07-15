using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Dominio.Entidades
{
    public class Motivo : Base
    {
        public override string ToString()
        {
            return Id +"-"+ Nome;
        }
    }
}
