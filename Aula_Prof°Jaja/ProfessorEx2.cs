using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercLPAulasJaja
{
    internal class ProfessorEx2
    {
        string nome = "Leandro";
        string nacionalidade = "Brasileira";
        string estado = "São Paulo";

        public static void Main(string[] args)
        {
            ProfessorEx2 professor = new ProfessorEx2();
            ProfessorEx2 suplente = new ProfessorEx2();

            Console.WriteLine($"A nacionalidade do professor {professor.nome} é: {professor.nacionalidade}, em seu estado: {professor.estado}; \n");
            
            suplente.nome = "Geraldo";
            Console.WriteLine($"A nacionalidade do professor suplente {suplente.nome} é: {suplente.nacionalidade}, em seu estado: {suplente.estado}. \n");

            //3° para Introdução da POO
        }
    }
}
