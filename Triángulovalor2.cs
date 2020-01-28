using System;

namespace Triangulovalor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertar el valor de d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insertar el valor de y");
            double y = double.Parse(Console.ReadLine());

            double bgrados = b * (Math.PI / 180);
            double dgrados = d * (Math.PI / 180);

            double e = Math.PI - (d + b);
            double c = Math.PI - e;
            double cgrados = c * (180 / Math.PI);
            double z = Math.Tan(c) * y;

            Console.WriteLine("El valor de z es" + z);
        }
    }
}
