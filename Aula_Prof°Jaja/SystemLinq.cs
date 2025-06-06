using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class SystemLinq
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Uso do Sistema Linq");

            int[] numeros = { 1, 5, 99, 33, 7};
            Console.WriteLine(numeros.Max() + " o maior/Max;"); //Traz o maior valor do vetor
            Console.WriteLine(numeros.Min() + " o menor/Min;"); //Traz o menor valor do vetor
            Console.WriteLine(numeros.Sum() + " a soma/Sum;"); //Traz a Soma dos números
            Console.WriteLine(numeros.Average() + " a média/Average;"); //Traz a média dos valores

        //Usando o System.Linq
        //Quero Bolsa - site para pesquisa das faculdadeshttps://www.faculdadeflamingo.com.br/

            //A parte .Average() é um método de extensão fornecido pelo LINQ
            //(Language Integrated Query). E serve para calcular a média de uma
            //coleção de números.
        }
    }
}
