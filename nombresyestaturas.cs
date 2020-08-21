using System;
using System.ComponentModel.DataAnnotations;

namespace nombresyestaturas
{
    class Program
    {
        static void Main()
        {
            
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };

            for(int j = 0; j < estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    double tmp = estatura[i];
                    estatura[i] = estatura[i + 1];
                    estatura[i + 1] = tmp;
                    
                }
                Console.WriteLine(estatura[j]);
                
            }
            for (int j = 0; j < nombres.Length; j++)
            {
                for (int i = 0; i < nombres.Length - 1; i++) 
                {
                    string tmp = nombres[i];
                    nombres[i] = nombres [i + 1];
                    nombres[i + 1] = tmp;

                }
                Console.WriteLine(nombres[j]);

            }

        }
    }
}
