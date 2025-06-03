using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComCSharp
{
    internal class CronometroFor
    {
        public static void Main(string[] args)
        {
            //Saindo de 0 a 59 - Cronômetro indo até 59:59 1 Hora
            /*Console.WriteLine("CRONÔMETRO de 1 Hora \n");

            for (int minutos = 0; minutos < 60; minutos++)
            {
                
                for (int segundos = 0; segundos < 60; segundos++)
                {
                    Console.WriteLine($"{minutos}:{segundos}");
                }
            }*/

            //Cronômetro indo até 23:59:59 - 1 Dia
            Console.WriteLine("CRONÔMETRO de 1 Dia \n");
            for (int horas = 24; horas < 24; horas++)
            {
                for (int minutos = 0; minutos < 60; minutos++)
                {
                    for (int segundos = 0; segundos < 60; segundos++)
                    {
                        Console.WriteLine($"{horas}:{minutos}:{segundos}");
                    }
                }
            }

            //Executa o segundo até cumprir os minutos, e os minutos até cumprir a hora.
        }
    }
}
