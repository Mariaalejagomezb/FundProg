using System;

namespace Triangulovalor4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertar el valor de w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de c");
            double c = double.Parse(Console.ReadLine());

            double cgrados = c * (Math.PI / 180);
            double z = Math.Sin(c) * t;
            double y = Math.Cos(c) * t;
            double d = Math.Asin(z / w);
            double x = (z / Math.Tan(d)) - y;

            Console.WriteLine("El valor de x es" + x);

        }
    }
}
