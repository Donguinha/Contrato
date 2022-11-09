using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoTrabalho.Contrato
{
    public class Contrato
    {
        public int Contratos { get; private set; }
        public DateTime data { get; private set; }
        public string ValorHora { get; private set; }
        public int Horas { get; private set; }

        public double ValorTotal(double valorhora, int horas)
        {
            return valorhora * horas;
        }
    }
}
