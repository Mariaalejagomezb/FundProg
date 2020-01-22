using System;

namespace triangulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribir el valor de y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el valor de z");
            double z = double.Parse(Console.ReadLine());

            double t = Math.Sqrt((Math.Pow(y, 2)) + (Math.Pow(z, 2)));

            double aGrados = Math.Asin(y / t) * (180 / Math.PI);
            double cGrados = Math.Asin(z / t) * (180 / Math.PI);

            Console.WriteLine("El valor de t es:" + t);
            Console.WriteLine("El valor del ángulo a es:" + aGrados);
            Console.WriteLine("El valor del ángulo c es:" + cGrados);
        }
    }
}
