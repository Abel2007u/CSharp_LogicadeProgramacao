using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ConversaoExplicita
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversão Exxplícita - Do > para o <.");

            double myDouble = 33.77;
            int myInt = (int)myDouble; //Conversão manual: double para int, definindo o tipo de dado na frente.

            Console.WriteLine(myDouble); //Output sairá 33.77
            Console.WriteLine(myInt); //Output sairá 33 - Desconsidera os decimais

            //MENOR AO MAIOR Implicit Casting (automatically) - converting a smaller type to a larger type size
            //char -> int -> long -> float -> double

            //AQUI MAIOR AO MENOR - Explicit Casting (manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            //Mais sobre o assunto: https://www.w3schools.com/cs/cs_type_casting.php
        }
    }
}
