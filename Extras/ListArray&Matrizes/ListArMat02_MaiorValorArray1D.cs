using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ListArMat02_MaiorValorArray1D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2: Encontrando o Maior Valor em um Array 1D");

            double[] decimais = { 5.4, 4.7, 3.2 };
            double maiorValor = Double.MinValue; //Pega o menor valor e o atribui como maior  PARA futura verificação

            Console.WriteLine("Valores no Array double decimais[]: \n");
            foreach (double item in decimais)
            {
                Console.WriteLine(item);
            }

            foreach (double item in decimais)
            {
                if (item > maiorValor)
                {
                    maiorValor = item; // Se o 'item' for maior, ele se torna o novo 'maiorValor'.
                }
            }

            Console.WriteLine($"\n O maior valor valor da Array é: {maiorValor}.");

            /*Exercício 2: Encontrando o Maior Valor em um Array 1D
                Objetivo: Aprimorar o uso de loops e condicionais com arrays.
                Enunciado: Escreva um programa que declare um array de números de ponto flutuante
                (double[]) e o inicialize com alguns valores. Utilize um loop foreach para percorrer o array e
                encontrar o maior valor presente nele. Ao final, exiba o maior valor encontrado.

             Docente de nível básico é Professor*/
        }
    }
}
