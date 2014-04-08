using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("write number=");
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            int sum = 0;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            for (int i = 1; i < n-1; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
                Console.WriteLine(sum);

            }
        }
    }
}
