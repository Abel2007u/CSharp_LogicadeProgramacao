using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class MetodoRetornar2Valores
    {
        static int SomaXY(int x, int y)
        {
            return x + y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Soma com dois valores X e Y: \n");
            Console.WriteLine(SomaXY(7,7));
        }

        //Usando a passagem de parâmetros, com retorno
    }
}
