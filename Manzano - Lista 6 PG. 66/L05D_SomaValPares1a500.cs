using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class L05D_SomaValPares1a500
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L05D - Soma dos Valores Pares de 1 a 500 \n");
            int soma = 0;

            for (int i = 1; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine($"A somatória dos valores Pares entre 1 a 500 é: {soma}.");

            //d) Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de 
            //1 até 500. 
            //O valor do RESULTADO é :  62750.
        }
    }
}
