using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPhrase = "hello computer bloopy bleepy bloop";
            Console.WriteLine(myPhrase);
            Console.WriteLine(myPhrase.Contains("computer"));

            // floating point numbers can be increased in precision with the 'double' numeric type

            int a = 5;
            int b = 2;
            int c = a / b;
            Console.WriteLine(c);

            double d = 6;
            double e = 4;
            double f = d / e;
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
