using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumIntervalDividableByGivenNumber
{
    class NumIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Start=");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End=");
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i= start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("P="+p);

        }
    }
}
