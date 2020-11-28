using System;

namespace seno
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.25, seno = 0;
            for(int i=0;i<100;i++)
            {
                seno += ((Math.Pow(-1, i) / Factorial(2 * i + 1))*(Math.Pow(x,(2*i+1))));
                Console.WriteLine("Seno: " + seno);
            }
        }
        static double Factorial(double sumatoriafacto)
        {
            if (sumatoriafacto <= 1) return 1; 
            return sumatoriafacto * Factorial(sumatoriafacto - 1);
        }
    }
}
