using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class Professor
    {
        string nome = "Jailson"; //vars globais que serão usadas
        int idade = 40; //Used in object tecnologia

        public static void Main(string[] args)
        {
            Professor tecnologia = new Professor();
            Console.WriteLine("O nome do Professor é: " + tecnologia.nome);
            Console.WriteLine($"A idade do Professor é: {tecnologia.idade}.");
        
            //Introduzindo POO
        }
    }
}
