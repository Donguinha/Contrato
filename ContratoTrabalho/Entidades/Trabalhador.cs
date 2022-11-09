using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoTrabalho.Entidades.Enumeração;

namespace ContratoTrabalho.Entidades
{
    public class Trabalhador
    {
        public string Nome { get; private set; }
        //public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; private set; }
    }    
    public void AddContrato(Contrato x)
    {
        Console.Write("Quantidade de horas no contrato: ");
        
    }
}
