using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumOf3int
{
    class SumOf3int
    {
        static void Main(string[] args)
        {
            Console.Write("Write a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Write b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Write c=");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(a+b+c);
        }
    }
}
