using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ExemploIFElse
    {
        public static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} é MAIOR > que {num2} .");
            } else
            {
                Console.WriteLine($"{num2} é MAIOR > que {num1} .");
            }
        }
    }
}
