using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class Swicht
    {
         static void Main(string[] args)
        {
            System.Console.WriteLine("1.- Suma");
            System.Console.WriteLine("2.- Resta");
            System.Console.WriteLine("3.- Multiplicacion");
            System.Console.WriteLine("4.- Division");
            System.Console.WriteLine("Elige la opcion");
            int Op= int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Primer valor");
            int N1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Segundo valor");
            int N2 = int.Parse(Console.ReadLine());
            switch (Op)
            {
                case 1:
                    int S = N1 + N2;

                    System.Console.WriteLine("El resultado es"
                        + S);
                    break;
                case 2:
                    int R = N2 - N1;
                    System.Console.WriteLine("El resultado es"
                        + R);
                    break;
                case 3:
                    int M = N1 * N2;
                    System.Console.WriteLine("El resultado es"
                        + M);
                    break;
                case 4:
                    int D = N1 / N2;
                    System.Console.WriteLine("El resultado" 
                        + D);
                    break;
                default:
                    System.Console.WriteLine("Opcion invalida");
                    break;
            }

            Console.ReadLine();

        }
    }
}
