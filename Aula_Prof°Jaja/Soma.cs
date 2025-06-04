using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class Soma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SOMA - Digite dois números para soma");
            
            Console.WriteLine("Digite o 1° Valor: ");
            int N1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o 2° Valor: ");
            int N2 = Convert.ToInt16(Console.ReadLine());

            int Soma = N1 + N2;

            Console.WriteLine("O resultado dessa Soma é: "+Soma+".");
            //Ctrl + K + F - Para indentar o código.
        }


    }
}
