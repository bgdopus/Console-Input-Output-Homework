﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double greater = a > b ? a : b; 
            Console.WriteLine(greater);
        }
    }
}
