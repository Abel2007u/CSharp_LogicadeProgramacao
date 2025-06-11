using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class A6ex2_areaQuadrado
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("6.2 - ÁREA DO QUADRADO");
            Console.WriteLine("Insira o valor do Lado deste Quadrado: ");
            int lado = Convert.ToInt16(Console.ReadLine());
            
            int areaQuadrado = lado * lado;

            Console.WriteLine($"\n A área deste Quadrado é: {areaQuadrado} cm².");
            Console.WriteLine("Muito obrigado por usar nosso sitema!");
         
        }
    }
}
