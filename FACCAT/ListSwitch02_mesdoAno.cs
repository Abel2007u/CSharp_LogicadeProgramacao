using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class ListSwitch02_mesdoAno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LSwitch 2 - Meses do Ano");
            Console.WriteLine("Insira o valor do respectivo mês: ");
            int mesAno = Convert.ToInt16(Console.ReadLine());

            switch(mesAno)
            {
                case 1:
                    Console.WriteLine("Janeiro inicia.");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro, menor mês do ano.");
                    break;
                case 3:
                    Console.WriteLine("Março, Hino 3.");
                    break;
                case 4:
                    Console.WriteLine("Abril, é o Quarto.");
                    break;
                case 5:
                    Console.WriteLine("Maio, é o Quinto e tem marco.");
                    break;
                case 6:
                    Console.WriteLine("Junho, metade do ano.");
                    break;
                case 7:
                    Console.WriteLine("Julho, opa férias escolares.");
                    break;
                case 8:
                    Console.WriteLine("Agosto é o Oitavo.");
                     break;
                case 9:
                    Console.WriteLine("Setembro o Nono.");
                    break;
                case 10:
                    Console.WriteLine("Outubro é o Décimo.");
                    break;
                case 11:
                    Console.WriteLine("Novembro, é o 11° e penúltimo.");
                    break;
                case 12:
                    Console.WriteLine("Dezembro, em breve um new year.");
                    break;
                case 13:
                    Console.WriteLine("Valor inválido, tente denovo com um valor correto.");
                    break;
            }
        }
    }
}
