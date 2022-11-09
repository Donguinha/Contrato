using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoTrabalho.Entidades.Enumeração;

namespace ContratoTrabalho.Entidades
{
    class Trabalhador
    {
        public string Nome { get; private set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; private set; }

        public Trabalhador(){}

        public Trabalhador(string Nome, NivelTrabalhador Nivel, double SalarioBase)
        {
            this.Nome = Nome;
            this.Nivel = Nivel;
            this.SalarioBase = SalarioBase;
        }

        public void AddContrato(DateTime data, double valorporhora, int horas)
        {
            Console.Write("Quantidade dos contratos de trabalho: ");
            var qtde = int.Parse(Console.ReadLine());

        }

        public void RemoverContrato(DateTime data, double valorporhora, int horas)
        {

        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nNível: {Nivel}\nSalário Base: {SalarioBase}";
        }

    }        
}
