using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class Matriz2D_Ex1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo da MATRIZ, no padrão: na primeira linha(0) e na primeira coluna(0) | {numeros[0,2]} | \n");

            int[,] numeros = { {1,2,5}, {3,6,8} };
            numeros[0,0] = 5; //Reatribuiu o valor da 1ª coluna de 1 para 5.
            Console.WriteLine($"{numeros[0,2]} \n"); //Imprime 5 = 1ª linha, no ultimo valor
            Console.WriteLine($"{numeros[1,2]} \n"); //Imprime 8 = 2ª linha, no ultimo valor
            Console.WriteLine($"{numeros[0,1]} . \n"); //Imprime 2 = 1ª linha, no segundo valor

            /*FOREACH - Usando loop dentro da matriz */
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            /*Usando GetLength() ao invés do Length podemos especificar quantas vezes o loop deve ser executado*/
            Console.WriteLine("Usando GetLength");
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine(numeros[i,j]);
                }
            }

            //Segue o PADRÃO: na primeira linha(0) e na primeira coluna(0)

            //https://www.w3schools.com/cs/cs_arrays_multi.php Mateiral Base para realização
            //Matriz que trabalha com duas dimensões, como uma forma de gelo 4x2 (Exemplo abaixo);
            //https://http2.mlstatic.com/D_NQ_NP_966385-MLU73618272536_122023-O.webp
        }
    }
}
