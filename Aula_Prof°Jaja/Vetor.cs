using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class Vetor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de VETOR");

            string[] carro = { "Volvo", "Ford", "BMW", "Mazda" };
            carro[0] = "Opel"; //Substituir Volvo por Opel que reatribuiu um novo valor a posição [0]

            int[] numero = { 10, 20, 30, 40 };
            numero[0] = 50; //Substituir 10 por 50 que reatribuiu um novo valor a posição [0]


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(carro[i]);
            }

            Console.WriteLine("\n"); //Quebra de linha separação

            for (int j = 0;j < numero.Length; j++)
            {
                Console.WriteLine(numero[j]);
            }

            //Vetor unidim. e Matriz é Bidimensional.
        }
    }
}
