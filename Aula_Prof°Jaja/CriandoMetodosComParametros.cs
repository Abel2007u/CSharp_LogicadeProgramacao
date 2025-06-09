using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class CriandoMetodosComParametros
    {
        static void Nome(string nome)
        {
            Console.WriteLine(nome + " Silva");
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Usando métodos com parâmetros: \n");
            
            Nome("Breno");
            Nome("Gabriel");
            Nome("Felipe");
            //Vimos a junção dos parâmetros com o método acima 
        }
    }
}
