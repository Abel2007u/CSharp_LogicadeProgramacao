using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class SobrecargaDeMetodo
    {
        static int MetodosSoma(int x, int y)
        {
            return x + y; //Retorna algo então não é void
        }

        static float MetodosSoma(float x, float y)
        {
            return x + y;
        }

        public static void Main(string[] args)
        {
            int myInt = MetodosSoma(7, 5);
            float myFloat = MetodosSoma(8.4f, 9.5f);
            Console.WriteLine($"A Soma dos números inteiros é: {myInt}.");
            Console.WriteLine($"A Soma dos números flutuantes é: {myFloat}.");
        }

        //Tendo a sobrecarga de método: pois o nome do método é o mesmo e só
        //muda o tipo de dado/parâmetro.
        //O método tendo o MESMO nome: Generalizando, e só altera o tipo de dado (O que remove o estigma de não poder usar o mesmo nome).
        //Muito usado no CleanCode
    }
}
