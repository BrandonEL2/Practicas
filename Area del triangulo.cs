using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class Area_del_triangulo
    {
        void Main(string[] args)
        {
            System.Console.WriteLine("Inserte 1er numero");
            double B1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("inserte 2do numero");
            double B2 = double.Parse(Console.ReadLine());
            double A = (B1 * B2) / 2;
            System.Console.WriteLine("El resultado de la Area es:" + A);
            Console.ReadKey();
        }
    }
}
