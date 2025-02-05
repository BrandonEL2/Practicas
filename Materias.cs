using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial
{
    internal class Materias
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa Materia");
            int M1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa calificacion");
            float P1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Materia");
            float M2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa calificacion");
            int P2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Materia");
            int M3 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa calificacion");
            int P3 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Materia");
            int M4 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa calificacion");
            int P4 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa Materia");
            int M5 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa calificacion");
            int P5 = int.Parse(Console.ReadLine());
            double S = P1 + P2 + P3 + P4 + P5;
            double P = S / 5;
            if (S > 6)
            {
                System.Console.WriteLine("Aprobado"
                    + P);
            }
            else
            {
                System.Console.WriteLine("Reprobado"
                    + P);
            }
            Console.ReadKey();

        }

    }
}
