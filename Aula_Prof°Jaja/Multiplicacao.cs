using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class Multiplicacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("MULTIPLICAÇÃO * - Insira dois valores...");
            Console.WriteLine("Digite o 1° Valor: ");
            int n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o 2° Valor: ");
            int n2 = Convert.ToInt16(Console.ReadLine());

            int multiplica = n1 * n2;

            Console.WriteLine($"\n O resultado dessa Multiplicação é: {multiplica}");
        }
    
    }
}
