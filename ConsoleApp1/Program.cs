using System;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Xml;
using static System.Convert;
using static System.Console;
using static ConsoleApp1.CustomApp;


namespace ConsoleApp1
{
    class Program

    {
        static void Main(string[] args)
        {
            double m = 3.83214;
            int k = (int)m;
            int l = ToInt32(m);
            WriteLine(l);
            double lk = Math.Round(m);
            WriteLine(lk);

            DateTime now = DateTime.Now;
            WriteLine(now);
        }
    }
}
