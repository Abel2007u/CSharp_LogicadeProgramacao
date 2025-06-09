using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class MetodosComMultiplosParametros
    {
        static void Informacoes(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos.");
        }

        public static void Main(string[] args)
        {
            Informacoes("Jailson", 43);
            Informacoes("Andressa", 19);
            Informacoes("Lucas Pereira", 20);

            //Chamando aqui o método informacoes
        }
    }
}
