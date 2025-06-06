using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class CriacaoVetorEPS
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de VETOR, com entrada do usuário; \n");

            //1ª Forma de criar um vetor, aqui para adicionar os valores depois
            string[] carro = new string[4]; //Vetor com valores setados
            for (int i = 0; i < carro.Length; i++)
            {
                Console.WriteLine($"Insira o nome do Carro, para a posição {i}: ");
                carro[i] = Console.ReadLine();
            }


            Console.WriteLine("\n");

            //Para mostrar
            foreach (string item in carro)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n");

            //2ª Forma de criar um vetor, aqui para adicionar os valores na hora
            string[] alunos = new string[4] {"De Souza","Rosilene","Andressa","Luccas"};
            foreach (string item in alunos) {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            //3ª Forma de criar um vetor, aqui para adicionar os valores mas sem especificar o tamanho
            string[] city = new string[] {"Tókio", "Rio de Janeiro", "Filadelfia"};
            foreach(string item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            //4ª e last Forma de criar um vetor, omitindo a palavra new e sem definir tamanho
            string[] fruta = { "Abacaxi", "Banana", "Caju" };
            foreach (string item in fruta)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n");

            string[] marca = { "Toro", "Fiat", "Volkswagen", "Uno" };
            for (int i = 0; i < marca.Length; i++)
            {
                Console.WriteLine(marca[i]); //Imprime até atingir o Length do carro, na última coluna
            }


            //maneira de usar um array no W3Schools.https://www.w3schools.com/cs/cs_arrays.php
            //As 4 maneiras de se pôr/usar um Array
            //Exemplo com entrada
        }
    }
}
