using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class L03A_tabuadaNum
    {
        public static void Main(string[] args)
        {
            int i = 1, numero;
            Console.WriteLine("L03A - TABUADA de um número inserido");
            Console.WriteLine("Insira um valor do seu agrado: \n");
            numero = Convert.ToInt16(Console.ReadLine());

            //Processo
            while (i < 11) {
                int resultado = i * numero;
                Console.WriteLine($"{numero} * {i} = {resultado}");
                i++;
            }

            Console.WriteLine("\n Obrigado por usar nosso sistema!");

            //a) Apresentar os resultados de uma tabuada de multiplicar(de 1 até 10) de um número qualquer
        }
    }
}
