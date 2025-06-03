using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class L05B_TabuadaNum1a10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L05B - Tabuada de um número qualquer de 1 a 10 \n");
            Console.WriteLine("Insira um valor do seu agrado, para ser multiplicado:");
            int num = Convert.ToInt16(Console.ReadLine());

            for (int numero = 1; numero < 11; numero++)
            {
                    int multiplica = num * numero;
                    Console.WriteLine($"{num} x {numero} = {multiplica}");   
            }
            //A variável local do for, chamando o valor da global inserida pelo usuário.

            //b) Apresentar os resultados de uma tabuada de multiplicar(de 1 até 10) de um número qualquer. 
        }
    }
}
