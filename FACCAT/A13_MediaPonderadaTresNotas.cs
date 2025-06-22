using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class A13_MediaPonderadaTresNotas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A13 - Media Ponderada com Três Notas \n");

            Console.WriteLine("Insira a 1ª Nota alcançada: ");
            float notaUm = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Insira a 2ª Nota obtida: ");
            float notaDois = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Insira a 3ª e última Nota: ");
            float notaTres = Convert.ToInt16(Console.ReadLine());

            //Calculo da média
            float mediaFinal = (notaUm*2 + notaDois*3 + notaTres*5)/10;

            if (mediaFinal >= 8)
            {
                Console.WriteLine($"\n Parabéns, sua média final foi {mediaFinal} - APROVADO!!!");
            }
            else if(mediaFinal >= 6)
            {
                Console.WriteLine($"\n Em crescimento, sua média final foi {mediaFinal}, com dedicação melhorarás!");
            }
            else
            {
                Console.WriteLine($"\n Reprovação, sua média final foi {mediaFinal}, será necessário refazer.");
            }

            //Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno.
            //Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5.Fórmula para o cálculo da média
            //final é:

            //mediafinal = n1 * 2 + n2 * 3 + n3 * 5 / 10
        }
    }
}
