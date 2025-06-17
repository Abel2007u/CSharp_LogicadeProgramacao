using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class Computador
    {
        string ram = "16GB";
        string monitor = "24 Polegadas";
        string processador = "AMD Rayzen 5208";
        int memoria = 512;

        public static void Main(string[] args)
        {
            Computador pc = new Computador();
            Console.WriteLine($"A memória ram é: {pc.ram}");
            Console.WriteLine($"O monitor é de: {pc.monitor}");
            Console.WriteLine($"O processador é: {pc.processador}");
            Console.WriteLine($"A memória é de: {pc.memoria}");

            //Introduzindo o POO pela 2ª
        }
    }
}
