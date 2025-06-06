using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class L05G_Base3aoExpoente15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("L05G - Exponeciação até 15 da base 3 \n");
            int baseInicio = 3;
            double resultado;

            for (int expoente = 0; expoente < 16; expoente++)
            {
                resultado = Math.Pow(baseInicio, expoente);
                Console.WriteLine($"A potência de {baseInicio}^{expoente} = {resultado}.");
            }

            //g) Apresentar os resultados das potências de 3, variando do expoente 0 até o expoente 15.Deve ser
            //considerado que qualquer número elevado a zero é 1, e elevado a 1 é ele próprio.Observe que
            //neste exercício não pode ser utilizado o operador de exponenciação do portuguol(^).
        }
    }
}
