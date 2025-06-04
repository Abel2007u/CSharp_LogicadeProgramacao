using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ExemploWhile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("EXEMPLO WHILE até i ser < 5");
            int i = 0;

            while(i < 5)
            {
                Console.WriteLine("Chegando no 5 MARCHA!");
                i++;
            }
        }
    }
}
