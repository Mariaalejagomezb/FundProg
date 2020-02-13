using System;

namespace BackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio=new Random();
            int carta1 = aleatorio.Next(1, 10);
            int carta2 = aleatorio.Next(1, 10);

            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("La primera carta es: "+ carta1);
            Console.WriteLine("La segunda carta es: " + carta2);
            int nuevacarta;
            int total = carta1 + carta2;
            string respuesta = "s";
            while (respuesta == "s"&& total < 21){

                nuevacarta = aleatorio.Next(1, 10);
                Console.WriteLine("Nueva carta: " + nuevacarta);
                total += nuevacarta;
                if (total <= 21) {
                    Console.WriteLine("Total:" + total);
                    Console.WriteLine("¿Desea otra carta?(s/n)");
                    respuesta = Console.ReadLine();
                }
                else{

                    Console.WriteLine("Deja de apostar, es malo manito, ya te quedaste pobre");
                }
            }
            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por jugar, " + nombre + ", ya ponte a hacer algo productivo nomames");
        }
    }
}
