using System;

namespace coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordsX = { 0, 2, 3, 7 };
            int[] coordsY = { 0, 1, 5, 6 };
            double mayor = 0;

            double pendiente = ((coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]));
            double pendiente1 = ((coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]));
            double pendiente2 = ((coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]));

            double intersecto = (coordsY[1] - (pendiente * coordsX[1]));
            double intersecto1 = (coordsY[2] - (pendiente1 * coordsX[2]));
            double intersecto2 = (coordsY[3] - (pendiente2 * coordsX[3]));


            if ((intersecto == intersecto1 && pendiente == pendiente1) && (intersecto1 == intersecto2 && pendiente1 == pendiente2))

            {
                Console.WriteLine("Si pertenecen a la misma recta");
            }
            else
            {
                Console.WriteLine("No pertenencen a la misma recta");
            }
            double distancia = Math.Sqrt((coordsX[1] - coordsX[0]) * (coordsX[1] - coordsX[0]) + (coordsY[1] - coordsY[0]) * (coordsY[1] - coordsY[0]));
            double distancia1 = Math.Sqrt((coordsX[2] - coordsX[1]) * (coordsX[2] - coordsX[1]) + (coordsY[2] - coordsY[1]) * (coordsY[2] - coordsY[1]));
            double distancia2 = Math.Sqrt((coordsX[3] - coordsX[2]) * (coordsX[3] - coordsX[2]) + (coordsY[3] - coordsY[2]) * (coordsY[3] - coordsY[2]));

            if (distancia > mayor) mayor = distancia;
            if (distancia1 > mayor) mayor = distancia1;
            if (distancia2 > mayor) mayor = distancia2;

            Console.WriteLine("La distancia Mayor es: " + mayor);
        }
    }
}
