using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class MatrizLoopFor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Revendo o Laço FOR, dentro da Matriz \n");

            int[,] numero = { {1,2,8}, {8,54,32} };

            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    Console.WriteLine(numero[i,j]);
                }
            }

            //Usando o laço for dentro de uma matriz
        }
    }
}
