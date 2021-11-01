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

        static void Task3()
        {
            double a;
            double b;
            int mod;

            Console.Write("Enter numder A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter numder B: ");
            b = Convert.ToDouble(Console.ReadLine());

            double result = a / b;
            mod = (int)(a % b);

            Console.WriteLine($"Result division A/B {result}");
            Console.WriteLine($"Remainder of division A/B {mod}");

        }

        static void Task4()
        {
            double a;
            double b;
            double c;

            Console.Write("Enter numder A: ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter numder B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter numder C: ");
            c = Convert.ToDouble(Console.ReadLine());

            double result = c / a - b / a;
            
            Console.WriteLine($"Result for A*X+B=C {Environment.NewLine}{result}");

        }

        static void Main(string[] args)
        {

            Task4();

        }
    }
}
