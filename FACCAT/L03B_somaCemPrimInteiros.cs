using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class L03B_somaCemPrimInteiros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L03B - Total da soma dos primeiros cem números \n");
            int i = 1; 
            int soma = 0;

            while(i < 101)
            {
                soma += i;
                i++;
            }
            Console.WriteLine($"A somatória dos 100 primeiros números é: {soma}.");

            //b) Apresentar o total da soma obtida dos cem primeiros números inteiros(1 + 2 + 3 + 4 + ...+98 + 99 + 100).
        }
    }
}
