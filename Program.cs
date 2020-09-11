using System;

namespace Matrices_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ingrese el número de filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el número de columnas");
            int columnas = int.Parse(Console.ReadLine());

            //datos primera matriz
            string[,] entrada = new string[filas, columnas];
            for (int i = 0; i <filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    entrada[i, j] = "-";
                }
            }
            //datos segunda matriz (ingresar)
            string[,] salida = new string[filas, columnas];
            for (int i = 0; i <filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                   
                    Console.Write("\nIngrese el valor en [" + i + "," + j + "] (X): ");
                    salida[i, j] = Console.ReadLine();
                    if (salida[i, j] == "X") Console.WriteLine("El valor [" + i + "," + j + "] ya está ocupado, pruebe con otra casilla");
                    
                }
            }
            //datos primera matriz (mostrar)
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("|" + entrada[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("\n");
            //datossegunda matriz (mostrar)
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }



        }
    }
}
