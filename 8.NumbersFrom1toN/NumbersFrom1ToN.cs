﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NumbersFrom1toN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
           
            Console.Write("number=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                
            }
            
            }
    }
}
