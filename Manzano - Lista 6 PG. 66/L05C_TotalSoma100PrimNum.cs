using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class L05C_TotalSoma100PrimNum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L05C - Total soma dos 100 primeiros números");
            int soma = 0;

            for (int num = 1; num < 101; num++)
            {
                soma = soma + num;
            }
            
            Console.WriteLine($"A somatória dos 100 primeiros números é: {soma}");

            //c) Apresentar o total da soma obtida dos cem primeiros números inteiros(1 + 2 + 3 + 4 + ...+98 + 99 + 100).
        }
    }
}
