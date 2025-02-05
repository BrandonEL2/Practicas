using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class If
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa el costo del producto");
            int N1= int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa el costo del producto");
            int N2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa el costo del producto");
            int N3 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa el costo del producto");
            int N4 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa el costo del producto");
            int N5 = int.Parse(Console.ReadLine());
            int S= N1+ N2+N3+N4+N5;
            double DS = (N1 + N2 + N3 + N4 + N5)*0.10;
            double RD = S - DS;
            double TC= S + RD;
            if (S > 2000)
            {
                System.Console.WriteLine("Total de los productos"
                    + S);
                System.Console.WriteLine("Total de descuento"
                    + DS);
                System.Console.WriteLine("Total de compra"
                    + TC);
            }
            else
            {
                System.Console.WriteLine("Totla de compra" 
                    + S);
                            }
            Console.ReadLine();
        }
    }
}
