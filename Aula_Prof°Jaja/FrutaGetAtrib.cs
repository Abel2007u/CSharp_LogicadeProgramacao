using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class FrutaGetAtrib
    {
        public static void Main(string[] args)
        {
            AtributosFruta fruta = new AtributosFruta();
            Console.WriteLine($"O nome da Fruta é {fruta.nome};");
            Console.WriteLine($"A cor da Fruta é {fruta.cor};");
            Console.WriteLine($"O preço da Fruta é {fruta.preco}.");

            //Chamando da classe AtributosFruta.cs
            //Sendo as boas práticas usadas no mercado.
        }
    }
}
