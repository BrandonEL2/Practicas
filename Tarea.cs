using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class Tarea}
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la operacion a realizar");
            int M= int.Parse(Console.ReadLine());
            Console.WriteLine("1. Area cuadrado");
            int A= int.Parse(Console.ReadLine());
            Console.WriteLine("2. Promedio");
            int PR=int.Parse(Console.ReadLine());
            Console.WriteLine("3. Temperatura");
            double T= double.Parse(Console.ReadLine());
            Console.WriteLine("4. Densidad");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("5. Masa");
            int MA= int.Parse(Console.ReadLine());
            Console.WriteLine("6. Volumen");
            int V = int.Parse(Console.ReadLine());
            Console.WriteLine("7. Puntaje");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Elige opcio");
            int Op= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el primer numero");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el primer numero");
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el primer numero");
            int N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el primer numero");
            int N4 = int.Parse(Console.ReadLine());
            switch (Op)
            {
                case 1:
                    Console.WriteLine("Area cuadrado");
                    int A1 = N1 * N2 * N3 * N4;
                    Console.WriteLine("El resultado es:" 
                        + A1);
                    break;
                case 2:
                    Console.WriteLine("Promedio");
                    int PR1 = int.Parse(Console.ReadLine());
                    double P1 = (N1 + N2 + N3 + N4) / 4;
                    Console.WriteLine("El resultado es:" 
                        + P1);
                    break;
                case 3:
                    Console.WriteLine("Temperatura");
                    double t= double.Parse(Console.ReadLine());
                    //swicht para este problema//

                    break;
                case 4:
                    Console.WriteLine("Densidad");
                    int D1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la Masa");
                    double m= double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el volumen");
                    double v = double.Parse(Console.ReadLine());
                    double p = m / v;
                    Console.WriteLine("La densidad es:"
                        + p);
                        break;
                    case 5:
                    Console.WriteLine("Masa");
                    int M1= int.Parse(Console.ReadLine());
                    //swicht para este problema//
                    break;
                case 6:
                    Console.WriteLine("Volumen");
                    int V1 = int.Parse(Console.ReadLine());
                    //swicht para este problema//
                    break;
                case 7:
                    Console.WriteLine("Puntaje");
                    int P2= int.Parse(Console.ReadLine());
                    int S2 = N1 + N2 + N3 + N4;
                    if (S2>100)
                    {
                        Console.WriteLine("Alto");
                    }
                    else
                    {
                        Console.WriteLine("Bajo");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }
            Console.ReadKey();
        }
    }
}
