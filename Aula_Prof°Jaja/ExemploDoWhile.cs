using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ExemploDoWhile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo com Do While");
            int i = 5;
            do
            {
                i++;
                Console.WriteLine(i);
            }
            while (i < 4);

            //Só fará uma vez pois a condição é falsa.
        }
    }
}
