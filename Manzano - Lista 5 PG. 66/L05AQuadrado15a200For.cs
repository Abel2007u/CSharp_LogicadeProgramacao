using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class L05AQuadrado15a200For
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L05A - Quadrado dos números de 15 a 200 \n");

            for (int i = 15;i < 201;i++)
            {
                int quadrado = i * i;
                Console.WriteLine($"O Quadrado do número {i}, é: {quadrado}");
            }

            Console.WriteLine("\n Obrigado por usar nosso sistema!");

            //a) Apresentar os quadrados dos números inteiros de 15 a 200. 
        }
    }
}
