using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class L05F_DividePor4Entre1e200
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L05F - Traz os valores Divisíveis por 4 entre 1 e 200 \n");

            for (int numero = 1; numero < 200; numero++)
            {
                if (numero % 4 == 0)
                {
                    Console.WriteLine($"Esse valor é divisível por 4: {numero}");
                }
            }

            //f) Apresentar todos os números divisíveis por 4 que sejam menores que 200.Para verificar se o
            //número é divisível por 4, efetuar dentro da malha a verificação lógica desta condição com a
            //instrução se, perguntando se o número é divisível; sendo, mostre - o; não sendo, passe para o
            //próximo passo. A variável que controlará o contador deve ser iniciada com o valor 1.
        }
    }
}
