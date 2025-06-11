using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class L04A_Quadrado15a200
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L04A - Quadrados entre 15 a 200 com Do-While \n");

            int i = 15;
            do
            {
                Console.WriteLine($"{i}² = {Math.Pow(i,2)}");
                i++;
            }
            while (i < 201);

            //a) Apresentar os quadrados dos números inteiros de 15 a 200.
        }
    }
}
