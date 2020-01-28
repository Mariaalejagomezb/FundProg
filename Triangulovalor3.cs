using System;

namespace Triangulovalor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertar el valor de w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de x");
            double x = double.Parse(Console.ReadLine());

            double dgrados = d * (Math.PI / 180);
            double z = w * Math.Sin(d);
            double y = (z / Math.Tan(d)) - x;

            Console.WriteLine("El valor de y es" + y);
        }
    }
}
