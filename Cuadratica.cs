using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class Cuadratica
    {
     void Main(string[] args)
    {
        System.Console.WriteLine("Ingresa a");
            float a= float.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingresa b");
            float b= float.Parse(Console.ReadLine());
        System.Console.WriteLine("Ingresa c");
            float c= float.Parse(Console.ReadLine());
        float Raiz = 2;
        float Raiz2 = 1 / Raiz;
            double x1 = (((-1) * (b)) + (Math.Pow(((Math.Pow(b, 2)) - (4 * (a * c))), Raiz2))) / (2 * a);
            double x2= (((-1)*(b))-(Math.Pow(((Math.Pow(b,2))-(4*(a*c))), Raiz2))) / (2 * a);
            System.Console.WriteLine("El resultado del area es: " + x1 + " y" + x2);
            Console.ReadKey();
    }  
}
}
