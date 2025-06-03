using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class L05E_NumImparesEntre1e20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L05E - Apresnta os valores Impares de 1 a 20 \n");

            for (int num = 1; num < 21; num++)
            {
                if (!(num % 2 == 0)) //Se não for par...
                {
                    Console.WriteLine($"Esse número inteiro é Impar: {num}.");
                }
            }

            //e) Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 20. Para verificar
            //se o número é ímpar, efetuar dentro da malha a verificação lógica desta condição com a instrução
            //se, perguntando se o número é ímpar; sendo, mostre - o; não sendo, passe para o próximo passo. 
        }
    }
}
