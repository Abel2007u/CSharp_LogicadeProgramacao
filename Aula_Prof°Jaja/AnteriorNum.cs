using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class AnteriorNum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("O ANTERIOR do número inserido;");
            Console.WriteLine("Insira um valor: ");
            int num = Convert.ToInt16(Console.ReadLine());

            int Anterior = num - 1;

            Console.WriteLine($"O Anterior do número inserido: {Anterior}");
        }
    }
}
