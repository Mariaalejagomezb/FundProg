using System;

namespace Dadosvida
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, contador = 0, contador2 = 0, vidas = 3;

            string tirar = "s";

            while (tirar == "s" && vidas > 0)
            {

                Console.WriteLine("¿Arrojar dados?(s/n)");
                tirar = Console.ReadLine();
                if (tirar != "s") break;
                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado= " + dado);
                total += dado;
                if (dado == 10) contador2 += 1;
                Console.WriteLine("total= " + total);
                Console.WriteLine("Vidas= " + vidas);

                if (tirar == "s")
                {
                    contador += 1;
                    if (dado == 1)
                    {
                        if (contador % 2 == 0 && vidas > 0)
                        {
                            vidas--;
                            total -= 10;

                        }
                        if (dado == 6) contador2 += 1;
                        if (dado!=6&&contador2>0)contador2--;
                        if (vidas > 3) vidas = 3;
                        if (contador2 == 2) vidas++;
                        if (vidas == 0)
                        {
                            Console.WriteLine("No tienes más vidas, has perdido");
                            break;
                        }
                        if (total==100){
                            Console.WriteLine("Has ganado");
                            break;
                        }
                    }

                }
            }
            Console.WriteLine("Gracias por jugar");
            Console.WriteLine("Vidas " + vidas);
            Console.WriteLine("total: " + total + "puntos");
        }
    }
}
