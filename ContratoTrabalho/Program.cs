using ContratoTrabalho.Entidades;
using ContratoTrabalho.Entidades.Enumeração;
using System;
using System.Collections.Generic;

namespace ContratoTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceberDepartamento();
            Trabalhador trabalhador1 = new Trabalhador(); 
            trabalhador1 = ReceberDados();
            
        }

        static void ReceberDepartamento()
        {
            Departamento depar = new Departamento();
            Console.Write("Departamento: ");
            depar.NomeDepartamento = Console.ReadLine();            
        }

        static Trabalhador ReceberDados()
        {            
            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nDados do trabalhador\nNome: ");
            var nome = Console.ReadLine();

            Console.Write("Nível (Junior/Nível médio/ Senior): ");
            var nivel = Console.ReadLine();
            NivelTrabalhador nivelenum = Enum.Parse<NivelTrabalhador>(nivel);

            Console.Write("Salário base: ");
            var salario = double.Parse(Console.ReadLine());
            Trabalhador trab1 = new Trabalhador(nome, nivelenum, salario);

            return trab1;
        }        
    }
}