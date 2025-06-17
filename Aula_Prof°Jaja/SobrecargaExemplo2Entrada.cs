using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class SobrecargaExemplo2Entrada
    {
        static int SomaMetodo(int x, int y)
        {
            return x + y;
        }

        static double SomaMetodo(double n1, double n2)
        {
            return n1 + n2; 
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("2° Exemplo de Sobrecarga - Valores INT \n");

            Console.WriteLine("Insira o 1° Valor: ");
            int x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Insira o 2° Valor: ");
            int y = Convert.ToInt16(Console.ReadLine());

            //Resultado 
            Console.WriteLine($"A soma desses valores Inteiros: {SomaMetodo(x,y)} \n");

            Console.WriteLine(" ------------------------------------- \n");
            
            Console.WriteLine("2° Exemplo de Sobrecarga - Double \n");

            Console.WriteLine("Insira o 1° valor: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o 2° valor: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            //Resultado
            Console.WriteLine($"A soma dos valores Double: {SomaMetodo(n1, n2)}");
        }

        //https://github.com/CodesdaLu/Programming-Books/tree/main Livros em um repositorio, este um dos 1°s na Alura
        //https://mail.elginbematech.com.br/processobook/Book%20Bematech%20Fev-2020/Bematech/Leitura%20Online/Livros/129%20-%20CSharp%20e%20Orienta%E7%E3o%20a%20Objetos%20-%20Caelum.pdf
    }
}
