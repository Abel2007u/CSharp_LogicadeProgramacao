using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ForEachSort2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Array.Sort - Classifica em ordem Crescente os números;");
            int[] numero = {1, 56, 21, 67, 43};
            Array.Sort(numero);

            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");


            Console.WriteLine("Array.Sort - Classifica em ordem alfabética os textos/strings -> cadeia de caracteres;");
            string[] carro = {"BMW", "Fusca", "Onix", "Gol"};
            Array.Sort(carro);

            foreach (string j in carro)
            {
                Console.WriteLine(j);
            }

            //Existem muitos métodos de array disponíveis, por exemplo Sort(), que classifica
            //um array em ordem alfabética ou crescente.https://www.w3schools.com/cs/cs_arrays_sort.php
            //Um foreachloop, que é usado exclusivamente para percorrer os elementos de um array
        }
    }
}
