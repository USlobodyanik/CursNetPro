﻿using System;

namespace HomeWorkL1
{
    class Program
    {

        static void Task1()
        {
            double a;
            double b;

            Console.Write("Enter numder A: ");
            string input = Console.ReadLine();
            a = Convert.ToDouble(input);

            Console.Write("Enter numder B: ");
            input = Console.ReadLine();
            b = Convert.ToDouble(input);

            double result = (5 * a + b * b) / (b - a);

            Console.WriteLine($"Result for task1:{Environment.NewLine}{result}");

        }
        static void Main(string[] args)
        {
            Task1();
            Console.ReadKey();

        }
    }
}
