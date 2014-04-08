using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumOfNnumbers
{
    class SumOfNnumbers
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            Console.Write("How many numbers=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter a number=");
                double number = double.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}
