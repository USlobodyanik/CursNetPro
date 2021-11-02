using ClassLibraryHomeWorkL1;
using System;

namespace ConsoleForTestLib
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task1 work with lib: ");
            double result = MyTestLibrary.Task1(4.5, 7);

            Console.WriteLine(result);

        }
    }
}
