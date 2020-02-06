using System;

namespace votos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votos partido 1"); 
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Población");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje");
            double porcentaje = double.Parse(Console.ReadLine());

            double mayores = n * (porcentaje / 100);
            int votantes = a + b + blancos + anulados;

            Console.WriteLine("Votos del partido 1" + a);
            Console.WriteLine("Votos del partido 2" + b);
            Console.WriteLine("Votos en blanco " + blancos);
            Console.WriteLine("Votos anulados " + anulados);
            Console.WriteLine("Votos totales " + votantes);
            Console.WriteLine("Poblacion de todas la edades " + n);
            Console.WriteLine("Poblacion Mayores de edad " + mayores);
            Console.WriteLine("Mayores de edad " + porcentaje);

            bool z = votantes > n;
            bool x = (a - b) < (votantes * 0.1);
            bool c = votantes < (n * 0.3);

            if ((z || x) && c)
            {
                Console.WriteLine("Se repiten las elecciones");
            }
            else if (a < b)
            {
                Console.WriteLine("El ganador es el partido 2");
            }
            else
            {
                Console.WriteLine("Elganador es el partido 1");
            }
        }
    }
}
