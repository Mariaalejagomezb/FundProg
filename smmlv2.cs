using System;

namespace smmlv
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariominimo = 877703;


            Console.WriteLine("Ingresar el salario que recibe");
            double smm = double.Parse(Console.ReadLine());

            if (salariominimo > smm * 2){

                Console.WriteLine("Tiene la tarifa A, su cuota moderadora es de $3.400");
            }
            else if (salariominimo * 2 <= smm && smm <= salariominimo * 5){

                Console.WriteLine("Tiene la tarifa B, su cuota moderadora es de $13.500");
            }
            else{
                Console.WriteLine("Tiene la tarifa C, su cuota moderadora es de $35.600");
            }

        }
    }
}
