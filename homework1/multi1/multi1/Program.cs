using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a double:");
            string a = Console.ReadLine();
            Console.Write("Please input a double:");
            string b = Console.ReadLine();
            double m = Double.Parse(a);
            double n = Double.Parse(b);
            Console.WriteLine(m + "*" + n + "=" + m * n);
            Console.ReadKey();
        }
    }
}
