using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class SubstringEIndexOf
    {
        public static void Main(string[] args)
        {
            //Nome completo usado
            String name = "John Doe";

            //Buscando pelo IndeOf a localização do 'D'
            int charPos = name.IndexOf("D"); //Aqui começa pelo 1° o se for "o"

            //Buscou o último nome se for D, o charPos
            string lastName = name.Substring(charPos);

            //Imprima para o user ver o resultado
            Console.WriteLine(lastName);

            /* EXEMPLO DE UPPER e LOWER 
             * string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            */
        }
    }
}
