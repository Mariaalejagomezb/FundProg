using System;

namespace programatriángulo1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escribir el valor de la hipotensusa");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribir valor del ángulo a");
            double aGrados = double.Parse(Console.ReadLine());

            double arad = aGrados * (Math.PI / 180);
            double y = Math.Sin(arad) * t;
            double z = Math.Cos(arad) * t;
            double cGrados = Math.Asin(z / t) * (180 / Math.PI);

            Console.WriteLine("El valor de y es:" + y);
            Console.WriteLine("El valor de z es:" + z);
            Console.WriteLine("El valor de c es" + cGrados);

            
            
        }
    }
}
