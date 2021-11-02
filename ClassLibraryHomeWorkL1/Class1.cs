using System;

namespace ClassLibraryHomeWorkL1
{
    public class MyTestLibrary
    {

        public static double Task1(double a, double b)
        {

            return (5.0 * a + b * b) / (b - a);

        }

        public static void Task2(ref string a, ref string b)
        {

            string temp = a;
            a = b;
            b = temp;

        }

        public static (double result, int mod) Task3(double a, double b)
        {

            return (a / b, Convert.ToInt32(a % b));

        }

        public static double Task4(double a, double b, double c)
        {

            return (c / a - b / a);

        }

        public static(double x, double y) Task5(double x1, double x2, double y1, double y2)
        {

            double x = (y1 - y2) / (x1 - x2);
            double y = y2 - x * x2;

            return (x, y);

        }

    }
}
