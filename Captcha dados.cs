using System;

namespace captcha2jugadores
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre = "";
            Random aleatorio = new Random();
            int puntos = 0;
            int contador = 0;
            int dado = 0;


            Console.WriteLine("Ingrese el numero de jugador");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los nombres");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Deseas empezar con el juego?");
            string r = Console.ReadLine();

            while (r == "s" && puntos < 100)
            {
                Console.WriteLine("¿Tirar dados?(s/n)");
                dado = aleatorio.Next(1, 7);
                if (r == "n") break;
                if (r == "s")
                {
                    Console.WriteLine("Dado" + dado);
                    puntos += dado;
                    if (dado == 1)
                    {
                        contador++;
                        Console.WriteLine("Contador: " + contador);
                        if (dado != 1) contador--;
                        if (contador == 3)
                        {
                            Console.WriteLine("Has perdido");
                            break;
                        }
                    }
                    if (puntos == 100)
                    {
                        Console.WriteLine("Has ganado");
                        break;

                    }
                }
            }
        }
    }
}
