using System;

namespace smmlv.ccf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte su salario en smmlv");
            int salariominimo = 877803;
            double smm = double.Parse(Console.ReadLine());

            if (smm < salariominimo * 2)  {

                Console.WriteLine("Tarifa A");

            }

            else if (salariominimo * 2<= smm && smm <= salariominimo * 4){

                Console.WriteLine("Tarifa B");
            }
            else{

                Console.WriteLine("Tarifa C");
            }
        }
    }
}
