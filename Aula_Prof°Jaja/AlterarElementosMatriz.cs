using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class AlterarElementosMatriz
    {
        public static void Main(string[] args){
            Console.WriteLine("Revendo atribuição na Matriz, de 2 para 5: \n");
            
            int[,] numeros = { { 2, 4, 6 }, { 3,5,7} };
            numeros[0, 0] = 5; //Trocou o 2 por 5

            Console.WriteLine(numeros[0,0]);

            //Revimos essa parte
        }
    }
}
