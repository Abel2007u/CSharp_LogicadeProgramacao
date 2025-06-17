using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class L04B_SomValPares1a500
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L04B - Somatória dos valores Pares de 1 a 500 \n");
            int i = 1;
            int soma = 0;

            do
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }

                i++;
            }
            while (i < 501); //Até o 500, e só exibe após ter terminado o processo.

            Console.WriteLine($"A somatória dos valores de 1 a 500 é: {soma}");

            //b) Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
            //1 até 500.
        }
    }
}
