﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double b;
            if (a < 0)
            {
                Console.WriteLine("Значение \"а\" должно быть не отрицательным");
                return;
            }
            b = Math.Sqrt(a);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
