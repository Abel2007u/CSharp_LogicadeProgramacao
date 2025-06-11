using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class A5_numAntecessor_Sucessor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A5. ANTECESSOR e SUCESSOR");
            Console.WriteLine("Insira um valor do seu agrado: ");
            int num = Convert.ToInt16(Console.ReadLine());

            int antecessor = num - 1;
            int sucessor = num + 1;

            Console.WriteLine($"O número é: {num}; \n e seu Antecessor: {antecessor}; \n E seu Sucessor: {sucessor}.");
        }
    }
}
