using System;
using ConsoleApp1;

namespace WritingFunctions
{
    class Program
    {

        static double Add(double b, double a)
        {
            return b * a;
        }

        static void Main(string[] args)
        {
            double a = 2.3;
            double b = 2.5;
            double c = Add(a, b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
