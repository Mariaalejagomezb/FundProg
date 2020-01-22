using System;

namespace triangulo3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escribir el valor de z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el valor del ángulo c");
            double cGrados = double.Parse(Console.ReadLine());

            double crad = cGrados * (Math.PI / 180);
            double y = z / (Math.Tan(crad));
            double t = Math.Sqrt(Math.Pow(y, 2) + (Math.Pow(z, 2)));
            double aGrados = Math.Atan(y / z) * (180 / Math.PI);

            Console.WriteLine("El valor de y es:" + y);
            Console.WriteLine("El valor de la hipotenusa es:" + t);
            Console.WriteLine("El valor del ángulo a es:"+ aGrados);
        }
    }
}
