using ClassLibraryHomeWorkL1;
using System;

namespace ConsoleForTestLib
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task1 work with lib: ");
            Console.WriteLine(MyTestLibrary.Task1(4.5, 7));

            Console.WriteLine("Task2 work with lib: ");
            string a = "String1";
            string b = "String2";
            Console.WriteLine($"Input str: {a} {b}");
            MyTestLibrary.Task2(ref a, ref b);
            Console.WriteLine($"Replaced str: {a} {b}{Environment.NewLine}");

            Console.WriteLine("Task3 work with lib: ");
            (double result, int mod) = MyTestLibrary.Task3(5.9, 4);
            Console.WriteLine($"Division Result :{result}{Environment.NewLine}" +
                $"Remainder of division: {mod}{Environment.NewLine}");

            Console.WriteLine("Task4 work with lib: ");
            Console.WriteLine(MyTestLibrary.Task4(3.4, 6.1, 12.0));

            Console.WriteLine("Task5 work with lib: ");
            (double x, double y) = MyTestLibrary.Task5(3.0, 2.1, 6.9, 4.0);
            Console.WriteLine($"Point X = {x}, Point Y = {y}{Environment.NewLine}");

        }
    }
}
