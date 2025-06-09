using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ListArMat01_Array1D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1: Soma de Elementos em um Array 1D");

            int[] numeros = { 3, 7, 2, 1, 5 };
            int totalSoma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                totalSoma += numeros[i];
            }

            Console.WriteLine(totalSoma);
            Console.WriteLine("Somando os 5 valores inseridos");

            /*Exercício 1: Soma de Elementos em um Array 1D - Aqui no Brasil Vetor e no US matriz unidimensional
                Objetivo: Praticar a criação e iteração sobre um array unidimensional com um loop for.
                Enunciado: Crie um programa que declare um array de inteiros(int[]) com 5 elementos.
                Preencha o array com quaisquer valores.Em seguida, use um loop for para calcular e exibir a
                soma de todos os elementos do array.*/
        }
    }
}
