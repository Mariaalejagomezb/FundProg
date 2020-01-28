using System;

namespace Triángulovalor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertar el valor de b");
            double bgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de y");
            double y = double.Parse(Console.ReadLine());

            double b = bgrados * (Math.PI / 180);

            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            double c = Math.Asin(z / t);
            double a = (Math.PI) - (Math.PI /(180/2)) - c;
            double d = (Math.PI) - (Math.PI) - (a + b);

            double x = (z / Math.Tan(d) - y);

            Console.WriteLine("El valor de x es" + x);
        }
    }
}
