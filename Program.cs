﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of term:");
            int n=Convert.ToInt32(Console.ReadLine());

            int n1 = 0, n2 = 1, nextTerm = 0;
            Console.Write($"Fibonacci Series for {n} terms are : ");

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.Write(n1 + " ");
                    continue;
                }
                if (i == 2)
                {
                    Console.Write(n2 + " ");
                    continue;
                }
                nextTerm = n1 + n2;
                n1 = n2;
                n2 = nextTerm;
                Console.Write(nextTerm + " ");
            }
            Console.WriteLine();
        }
    }
}
