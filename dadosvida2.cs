using System;

namespace dadosturnopierdevida
{
    class Program
    {
        static void Main(string[] args)
        {
            int turnos = 0, vidas = 3, dado = 0, puntos = 0, dado2 = 0;
            string tirar = "s";
            Random aleatorio = new Random();
            Random aleatorio2 = new Random();

            while (tirar == "s" && vidas > 0)
            {
                Console.WriteLine("¿Tirar dado?(s/n)");
                tirar = Console.ReadLine();
                turnos++;
                Console.WriteLine("Turno #" + turnos);
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("puntos: " + puntos);
                puntos += dado;
                Console.WriteLine("vidas: " + vidas);
                Console.WriteLine("dado: " + dado);


                if (turnos % 2 == 0)
                {
                    Console.WriteLine("Has perdido una vida");
                    vidas--;
                }

                if (turnos % 3 == 0)
                {
                    dado2 = aleatorio2.Next(1, 7);
                    Console.WriteLine("Tira otro dado para una oportunidad de vida extra");
                    Console.WriteLine("dado#2: " + dado2);
                    if (dado2 == dado)
                    {
                        vidas++;
                        Console.WriteLine("Has ganado una vida");
                    }

                }
                if (tirar != "s")
                {
                    Console.WriteLine("Gracias por jugar");
                    break;
                }
                if (puntos==100)
                {
                    Console.WriteLine("Has ganado!");
                    break;
                }
                if (vidas==0)
                {
                    Console.WriteLine("Has perdido");
                    break;
                }
            }

        }
    }
}
