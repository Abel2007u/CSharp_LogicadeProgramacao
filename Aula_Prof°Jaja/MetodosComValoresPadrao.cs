using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class MetodosComValoresPadrao
    {
        static void Pais(string pais = "Brasil")
        {
            Console.WriteLine($"Localidade: {pais}.");
        }
        
        public static void Main(string[] args)
        {
            Pais("Espanha");
            Pais("Holanda");
            Pais(); //Virá o valor Padrão => Brasil
            Pais("Inglaterra");
        }
    }
}
