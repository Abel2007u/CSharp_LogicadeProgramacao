using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class A6ex3_areaCirculo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("6.3 - ÁREA DO CÍRCULO");
            Console.WriteLine("Insira o valor do Raio deste Círculo: ");
            int raio = Convert.ToInt16(Console.ReadLine());
;            
            double areaCirculo = raio * raio * Math.PI;

            Console.WriteLine($"\n A área deste Círculo é: {areaCirculo} cm³.");
            Console.WriteLine("Muito obrigado por usar nosso sitema!");

            //areaCirculo < -raio * raio * pi
        }
    }
}
