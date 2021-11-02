using ClassLibraryHomeWorkL1;
using System;

namespace ConsoleForTestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "String1";
            string b = "String2";

            MyTestLibrary.Task2(ref a, ref b);

            Console.WriteLine(a + b);

        }
    }
}
