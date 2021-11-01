using System;

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
        static void Task2()
        {
            string a;
            string b;

            Console.WriteLine("Enter string 1: ");
            a = Console.ReadLine();
            string temp = a;

            Console.WriteLine("Enter string 2: ");
            b = Console.ReadLine();
            
            a = b;
            b = temp;

            Console.WriteLine($"Result String 1: " + a + " String 2: " + b);

        }
        static void Main(string[] args)
        {

            Task2();

        }
    }
}
