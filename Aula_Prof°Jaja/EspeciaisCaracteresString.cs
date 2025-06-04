using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class EspeciaisCaracteresString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("# Caracteres Especiais, quando usamos ' , '' ou /");

            //Aqui daria erro no ", por reconhecer o fechamento
            //string txt = "A história dos "Vikings" é uma grande jornada.";

            //Exemplo do Single quote/aspas Simples
            string aspasSimples = "Essa é uma \'alegoria\'";

            //Exemplo do Duplo quote/aspas Duplas
            string aspasDuplas = "Duas \"bençãos\", get the sarcarmo.";

            //Exemplo do Barra \
            string barra = "ELE é Belo\\Inteligente.  \n \n";

            Console.WriteLine(aspasSimples);
            Console.WriteLine(aspasDuplas);
            Console.WriteLine(barra);

            /*Escape character	Result	Description
                \' 	'    Single quote
                \"	"    Double quote
                \\	\	Backslash*/

            Console.WriteLine("# Caracteres Especiais, quando usamos \\n, \\t ou \\b");

            //Exemplo da Quebra de linha \n
            string quebraLinha = "Emcima e aqui \n embaixo :)";

            //Exemplo do Espaçamento de linha \t
            string usoTab = "Aplicando o espaçamento \t TAB ;D";

            //Exemplo com o Backspace
            string back = "Use o \bBackSpace também ;]";

            Console.WriteLine(quebraLinha);
            Console.WriteLine(usoTab);
            Console.WriteLine(back);

            /*Code Result  Try it
            \n New Line
            \t Tab	
            \b Backspace*/
        }
    }
}
