using System;
using System.Numerics;

namespace BlackJackOrden
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string mascartas = "";
            Console.WriteLine("¡Empezamos!");
            Console.WriteLine("¿Desea seguir?(s/n)");
            string respuesta = Console.ReadLine();
            Console.WriteLine("Ingrese el número de jugadores (min 2 max 5)");
            int n = int.Parse(Console.ReadLine());
            int[] puntajes = new int[n];
            for(int i=0;i<puntajes.Length;i++)
            {
                Console.WriteLine("Bienvenido jugador " + i + 1);
                int carta1 = aleatorio.Next(1, 11);
                int carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Su primera carta señor: " + carta1);
                Console.WriteLine("Su segunda carta señor: " + carta2);
                int ncarta;
                int total = carta1 + carta2;
                Console.WriteLine("Total: " + total);
                while(total<21)
                {
                    Console.WriteLine("¿Desea una nueva carta?");
                    mascartas = Console.ReadLine();
                    if (mascartas != "s") break;
                    ncarta = aleatorio.Next(1, 11);
                    total += ncarta;
                    Console.WriteLine("Nueva carta: " + ncarta);
                    Console.WriteLine("total: " + total);
                    if(total==21)
                    {
                        Console.WriteLine("Ganaste!");
                        break;
                    }
                    if (total>21)
                    {
                        Console.WriteLine("¡Perdiste!");
                        Console.WriteLine("Te pasaste de 21");
                        total = 0;
                        Console.WriteLine("total" + total);
                        break;
                    }
                   
                }
                puntajes[i] = total;
            }
            int max = 0, segundo = 0, nomax = 0, nom2 = 0;
            for (int i = 0; i < puntajes.Length; i++)
            {
                if (puntajes[i] > max)
                {
                    max = puntajes[i];
                    nomax = i;
                }
            }
            for(int j=0;j<puntajes.Length;j++)
            {
                if(puntajes[j]>segundo&&puntajes[j]<max)
                {
                    segundo = puntajes[j];
                    nom2 = j;
                }
            }
            Console.WriteLine("Primer puesto. jugador# " + nomax + 1 + "puntaje de" + puntajes[nomax]);
            Console.WriteLine("Segundo puesto. jugador# " + segundo + 1 + "puntaje de" + puntajes[nom2]);
        }
    }
}
