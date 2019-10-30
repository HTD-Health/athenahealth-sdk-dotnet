using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthenaHealth.Tools.WebDocParser;

namespace AthenaHealth.Tools.WebDocComparer
{
    public static class Comparer
    {
        public static void Compare()
        {
            var in1 = Parser.ParseItems("WebDocComparer\\in1.html");
            var in2 = Parser.ParseItems("WebDocComparer\\in2.html");

            Console.WriteLine("Scanning in1 against in2...");
            foreach (var item in in1)
            {
                if (!in2.Contains(item))
                    Console.WriteLine($"{item.Name} ({item.Type}) exists in in1.html, but not exists in in2.html");
            }

            Console.WriteLine("Scanning in2 against in1...");
            foreach (var item in in2)
            {
                if (!in1.Contains(item))
                    Console.WriteLine($"{item.Name} ({item.Type}) exists in in2.html, but not exists in in1.html");
            }

            Console.ReadKey();
        }
    }
}
