using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DIVISÃO / - Insira dois valores...");
            Console.WriteLine("Insira o 1° Valor: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Certo, agora o 2° Valor: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            int divisao = num1 / num2;

            if (num1 == 0) 
            {
                Console.WriteLine("Não pode ter divisão por 0.");
            }
            else if (num2 == 0)
            {
                Console.WriteLine("Não pode ter divisão por 0.");
            }
            else
            {
                Console.WriteLine($"O resultado dessa divisão é: {divisao}");
            }

        }
    }
}
