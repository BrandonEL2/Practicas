using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class Puntos
    {
         void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa x2");
            float x2= float.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrsa x1");
            float x1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa y2");
            float y2= float.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa y1");
            float y1 = float.Parse(Console.ReadLine());
            float Raiz = 2;
            float Raiz2= 1/Raiz;
            double Distancia = Math.Pow ((Math.Pow((x2-x1),2))+ (Math.Pow((y2-y1),2)), Raiz2);
            System.Console.WriteLine("El resultado del area es:" + Distancia);
            Console.ReadKey();
        }
      
    }
}
