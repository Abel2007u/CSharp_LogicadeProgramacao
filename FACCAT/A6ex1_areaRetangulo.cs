using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class A6ex1_areaRetangulo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("6.1 - ÁREA DO RETÂNGULO");
            Console.WriteLine("Insira o valor real da Base: ");
            int baseRet = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Certo, insira agora o valor da Altura:");
            int altura = Convert.ToInt16(Console.ReadLine());

            int areaRetangulo = baseRet * altura;

            Console.WriteLine($"\n A área deste Retângulo é: {areaRetangulo} cm³.");
            Console.WriteLine("Muito obrigado por usar nosso sitema!");
            
            //areaRet < -base * altura
            //FACCAT 6) Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a
            //área do retângulo.
        }
    }
}
