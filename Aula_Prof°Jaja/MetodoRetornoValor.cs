using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class MetodoRetornoValor
    {

        static int Soma(int x)
        {
            return x + 10;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Usando de um método com retorno, nesse caso Soma (int x + 10) \n");
            Console.WriteLine(Soma(7));
        }

        //Onde há retorno não se usa o void
    }
}
