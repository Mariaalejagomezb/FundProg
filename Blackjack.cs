using System;

namespace BlackJackcl12
{
    class Program
    {
        static void Main()
        {
            
        

            Console.WriteLine("Hola!, empezamos");
            Console.WriteLine("Ingresa un número de jugadores (min 2 - max 5");
            int i = int.Parse(Console.ReadLine());
            int j = 0, w = 0;
            int[] puntaje = new int[i];

            while (i < 2 || i > 5) 
            {
                Console.Write("por favor ingresa un número válido");
                i = int.Parse(Console.ReadLine());
            }

            for (j = 0; j < i; j++)
            {
                Console.Write("Bienvenido, jugador " + (j + 1));
                Random aleatorio = new Random();
                string continuar = "s";
                int carta1 = 0, total = 0;

                while (total < 21 && continuar == "s")
                {
                    carta1 = aleatorio.Next(1, 11);
                    total += carta1;

                    if (total > 21)
                    {
                        Console.WriteLine("ELIMINADO");
                        total = 0;
                        break;
                    }
                    Console.Write("Carta = " + carta1);
                    Console.Write(" Puntos totales = " + total);
                    Console.WriteLine(" ¿Desea tomar otra carta? (s/n): ");
                    string Continuar = Console.ReadLine();
                    puntaje[j] = total;
                }
                Console.WriteLine("Gracias por participar");
            }
            int mayor = 0;
            int jugador = 0;
            while (w < j)
            {
                if (puntaje[w] > mayor)
                {
                    mayor = puntaje[w];
                    jugador = w + 1;

                }
                w++;
            }
            Console.Write("el jugador con el mayor puntaje es: " + jugador);

            jugador -= 1;
            puntaje[jugador] = 0;
            w = 0;
            mayor = 0;

            while (w < j)
            {
                if (puntaje[w] > mayor)
                {
                    mayor = puntaje[w];
                    jugador = w + 1;

                }
                w++;
            }
            Console.Write("el jugador con segundo el mayor puntaje es: " + jugador);

            Console.Read();




        }
    }
}
