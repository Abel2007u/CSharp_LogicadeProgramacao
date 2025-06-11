using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class ListSwitch01_diaSemana
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LSwitch 1 - Dias da semana");
            Console.WriteLine("Insira um número para o respectivo dia:");
            int diaSemana = Convert.ToInt16(Console.ReadLine());

            switch(diaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo é o primeiro.");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira, bora trabalhar.");
                    break;
                case 3:
                    Console.WriteLine("Terça- feira let's study.");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira, Hino 258.");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira, voltando do PROA.");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira, concluindo a semana.");
                    break;
                case 7:
                    Console.WriteLine("Sábado, dia do Senhor.");
                    break;
                default:
                    Console.WriteLine("Não há húmero correspondente, tente novamente com um valor válido.");
                    break;
            }

        }
    }
}
