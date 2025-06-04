using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja { 
    internal class Subtracao
    {

        public static void Main(string[] args)
        {
            int nm1, nm2;
            Console.WriteLine("SUBTRAÇÃO - _ Digite dois números para cálculo:");
            Console.WriteLine("Digite o 1° Valor: ");
            nm1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o 2° Valor: ");
            nm2 = Convert.ToInt16(Console.ReadLine());

            int subtracao = nm1 - nm2;

            Console.WriteLine($"\n O valor da Subtração é: {subtracao}");
        }

    }
}
