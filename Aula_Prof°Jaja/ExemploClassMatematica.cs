using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ExemploClassMatematica
    {
        public static void Main(string[] args)
        {
            //Math.Max mostra o MAIOR valor entre os dois inseridos(x,y)
            Console.WriteLine(Math.Max(5, 10));

            //Math.Min mostra o MENOR valor entre os dois inseridos(x,y)
            Console.WriteLine(Math.Min(5,10));

            //Math.Sqrt mostra a raíz quadrada do valor inserido (x)
            Console.WriteLine(Math.Sqrt(16));

            //Math.Abs mostra o valor ABSOLUTO : quantas casas precisa andar para chegar no 0,
            //sendo portanto sempre positivo 
            Console.WriteLine(Math.Abs(-7.1)); //Sempre traz um valor positivo

            //Math.Round ARREDONDA para o valor inteiro mais próximo(x)
            Console.WriteLine(Math.Round(9.99));


            // double result = Math.Pow(Math.E, 2); e ao quadrado
            //Passo a passo da Classe Math https://www.w3schools.com/cs/cs_math.php
        }
    }
}
