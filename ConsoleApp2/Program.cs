using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;
using ConsoleApp2.ClassToTry;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            Trace.AutoFlush = true;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            var ts = new TraceSwitch(
                displayName: "PacktSwitch",
                description: "Descrtiption"
                );

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLine(ts.TraceError, "Trace error");

            Debug.WriteLine("Debug");
            Trace.WriteLine("Trace");
        }
    }
}
