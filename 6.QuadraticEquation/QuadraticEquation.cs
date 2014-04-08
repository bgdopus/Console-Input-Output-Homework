using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("D=" + d);
            if (d > 0 || d == 0)
            {
                if (d == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("X= " + x);

                }
                else
                {
                    double x1=(-b + Math.Sqrt(d))/(2*a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("X1="+x1);
                    Console.WriteLine("X2="+x2);
                }
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
