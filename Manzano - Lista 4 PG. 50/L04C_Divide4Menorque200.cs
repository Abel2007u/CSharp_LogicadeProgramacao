using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPFaccat
{
    internal class L04C_Divide4Menorque200
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L04C - Todos os números % por 4 menores que 200 \n");
            int i = 1;

            do
            {
                
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i < 200);

            //c) Apresentar todos os números divisíveis por 4 que sejam menores que 200.Para verificar se o
            //número é divisível por 4, efetuar dentro da malha a verificação lógica desta condição com a
            //instrução se, perguntando se o número é divisível; sendo, mostre - o; não sendo, passe para o
            //próximo passo. A variável que controlará o contador deve ser iniciada com o valor 1.
        }
    }
}
