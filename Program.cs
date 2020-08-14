using System;

namespace Dado_vida_puntos
{
    class Program
    {
        static void Main(string[] args)
        {
            int dado = 0, dado2 = 0, vidas = 3, turnos = 0, total = 0;
            string respuesta = "";
            Random aleatorio= new Random();
            while (respuesta=="s")
            {
                
                Console.WriteLine("¿tirar dado?(s/n)");
                respuesta = Console.ReadLine();
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("dado:" + dado);
                turnos++;
                total += dado;
                  if (turnos % 2 == 0)
                  {
                    vidas--;
                  }
                   
                if (respuesta != "s") break;
                if (turnos %3==0)
                {
                    Console.WriteLine("Puedes usar dos dados");
                    dado2 = aleatorio.Next(1, 7);
                    if (dado == dado2) vidas++;
                    total += (dado + dado2);
                }
                if(total>=100)
                {
                    Console.WriteLine("Ganaste!");
                    break;
                }
                if(vidas==0)
                {
                    Console.WriteLine("Te quedaste sin vidas");
                    break;
                }
                

            }
        }
    }
}
