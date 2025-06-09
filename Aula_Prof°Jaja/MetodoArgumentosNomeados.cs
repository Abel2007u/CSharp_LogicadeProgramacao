using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class MetodoArgumentosNomeados
    {
        static void Crianca(string crianca1, string crianca2, string crianca3)
        {
            Console.WriteLine($"A criança mais jovem é: {crianca3}.");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Aqui um método por Valor, e não preferência: \n");

            Crianca(crianca3: "Gabriel de Souza", crianca2:"Andre",crianca1:"Caio");
            //Por valor, chama na ordem que você quiser.
        }

        //Aqui não por preferencia/posicao, mas valor
    }
}
