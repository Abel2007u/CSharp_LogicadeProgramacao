using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class A1_TrocaAtoB
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A1. Troca de valor A para B");
            Console.WriteLine("Now - A é 20, e B é 10. \n");

            int A = 20;
            int B = 10;
            int C = A;
            A = B;
            B = C;

            Console.WriteLine($"APÓS - A é {A} e B: {B}, TROCA REALIZADA!");
        }

    }
}
