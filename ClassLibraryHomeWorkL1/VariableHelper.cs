using System;

namespace HomeWorkLibrary
{
    public class VariableHelper
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

        public static (int result, int mod) Task3(int a, int b)
        {
            return (a / b, (a % b));
        }

        public static double Task4(double a, double b, double c)
        {
            return (c / a - b / a);
        }

        public static(double x, double y) Task5(double x1, double x2, double y1, double y2)
        {
            return ((y1 - y2) / (x1 - x2), y2 - ((y1 - y2) / (x1 - x2)) * x2);
        }
    }
}
