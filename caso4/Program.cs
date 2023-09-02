using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos minutos duro la llamada? : ");
            int Tiempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Que dia fue ? :(1: domingo, 2 : lunes,...,7 sabado)");
            int diaSem = int.Parse(Console.ReadLine());
            Console.WriteLine("Que turno fue ?: (1: matutino, 2 vespertino)");
            int turno = int.Parse(Console.ReadLine());

            float llamadacos = 0.0f;

            if (Tiempo <= 5)
            {
                llamadacos = Tiempo * 1.00f;

            }
            else if (Tiempo <= 8)
            {

                llamadacos = (Tiempo - 5) * 0.8f + 5;

            }
            else if (Tiempo <= 10)
            {

                llamadacos = (Tiempo - 8) * 0.7f + 7.4f;
            }
            else
            {

                llamadacos = (Tiempo - 10) * 0.5f + 8.8f;

            }
            float impuesto = 0.0f;

            if (diaSem == 1)
            {

                impuesto = llamadacos * 0.03f;
            }
            else if (diaSem >= 2 && diaSem <= 6)
            {
                if (turno == 1)
                {
                    impuesto = llamadacos * 0.15f;
                }
                else if (turno == 2)
                {
                    impuesto = llamadacos * 0.10f;
                }

            }
            float costoTotal = llamadacos + impuesto;
            Console.WriteLine("Costo de la llamada: " + llamadacos);
            Console.WriteLine("Impuesto: " + impuesto);
            Console.WriteLine("Costo total: " + costoTotal);
            Console.ReadKey();
        }
    }
}
