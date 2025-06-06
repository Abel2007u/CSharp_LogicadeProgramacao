using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ForEachExemplo02
    {
        public static void Main(string[] args)
        {
            string[] carro = {"Volvo","BMW","Volkswagen","Hyundai"};
            carro[0] = "Opel"; //Reatribuiu o 1° valor de Volvo para Opel
            foreach (string marca in carro)
            {
                Console.WriteLine(marca);
            }

            Console.WriteLine(carro.Length); //Traz quantos valores tem, nesse caso 4

            //Com base também no W3School.https://www.w3schools.com/cs/cs_arrays_loop.php
        }
    }
}
