using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Write r= ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2*Math.PI*r;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Perimeter = {0:F2}  S = {1:F2}", perimeter, s);
        }
    }
}
