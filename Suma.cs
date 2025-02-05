using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class Suma
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Inserte 1er numero");
            int N1= int.Parse(Console.ReadLine());
            System.Console.WriteLine("inserte 2do numero");
            int N2= int.Parse(Console.ReadLine());
            int S = N1+N2;
            System.Console.WriteLine("El resultado de la Suma es:" + S);
            Console.ReadKey();
        }
    }
}
