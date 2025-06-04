using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class PosteriorNum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("POSTERIOR do número inserido;");
            Console.WriteLine("Insira um valor do seu agrado:");
            int num = Convert.ToInt16(Console.ReadLine());

            int posterior = num + 1;

            Console.WriteLine($"O Posterior do número digitado é: {posterior}");
        }
    }
}
