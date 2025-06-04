using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ExemploIFElseVoto2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo VOTO - IF, Else e ElseIF");
            Console.WriteLine("Insira sua idade, para validar se pode votar:");
            int idade = Convert.ToInt16(Console.ReadLine());

            //Validação
            if (idade < 16)
            {
                Console.WriteLine("Você ainda é menor de idade não precisa votar.");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Voto opcional, de sua escolha.");
            }
            else
            {
                Console.WriteLine("É maior de idade, seu voto é obrigatório.");
            }

            //Com if ternario
            //string verificar = (idade < 16) ? "Não pode votar." : (idade < 18) ? "Seu voto é opcional." : "Seu voto é Obrigatório!";
            //Console.ReadLine(verificar);
        }
    }
}
