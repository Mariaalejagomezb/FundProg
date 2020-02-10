using System;

namespace salariominimoswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribir tipo de contrato(1=dependiente, 2= independiente)");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el valor del salario");
            double s = double.Parse(Console.ReadLine());

            double cotizacion = s * 0.4;
            double arl = 0;
            double smmlv = 877833;

            if (cotizacion < smmlv)
            {

                cotizacion = smmlv;


            }

            switch (c)
            {

                case 1:
                    Console.WriteLine("Su contrato no posee arl");
                    double pension = cotizacion * 0.04;
                    double eps = cotizacion * 0.04;
                    double deduccion = -eps - pension;
                    double salarioreal = s + deduccion;
                    double bonificacion = s;
                    double salarioanual = (salarioreal * 12) + bonificacion;
                    Console.WriteLine("Su salario real es" + salarioreal);
                    Console.WriteLine("Su salario anual es" + salarioanual);
                    break;
                case 2:
                    Console.WriteLine("Número de riesgo laboral (1-5)");
                    int d = int.Parse(Console.ReadLine());
                    double pensión = cotizacion * 0.16;
                    double epss = cotizacion * 0.125;
                    double pdeduccion = -pensión - epss - arl;
                    switch(d){
                        case 1:
                            arl = cotizacion * 0.00522;
                            break;
                        case 2:
                            arl = cotizacion * 0.01044;
                            break;
                        case 3:
                            arl = cotizacion * 0.02436;
                            break;
                        case 4:
                            arl = cotizacion * 0.04350;
                            break;
                        case 5:
                            arl = cotizacion * 0.06960;
                                            break;
                    }
                    double realsalario = s + pdeduccion;
                    double anualsalario = realsalario * 12;
                    Console.WriteLine("Su salario real es" + realsalario);
                    Console.WriteLine("Su salario anual es" + anualsalario);
                           break;

            }
        }
    }
}
