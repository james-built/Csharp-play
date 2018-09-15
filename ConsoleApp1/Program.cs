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

            // fixed point numbers where the decimal doesn't move are the 'decimal' numeric type
            List<Secondary> listSec = new List<Secondary>();
            Secondary sec1 = new Secondary();
            sec1.i = 1;
            Secondary sec2 = new Secondary();
            sec2.i = 2;
            listSec.Add(sec1);
            listSec.Add(sec2);
            foreach(Secondary sec in listSec)
            {
                Console.WriteLine(sec.Second("james"));
            }
            Console.WriteLine(sec1.Second("james"));
            Console.ReadLine();
        }
        
    }
    public class Secondary
    {
        public int i = 0;
        public string Second(string name)
        {
            return "hello" + i.ToString();
        }
    }
}
