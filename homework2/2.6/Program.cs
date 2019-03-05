using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input an int :");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            int i;
            if (n < 2)
                Console.WriteLine("there is no prime factor.");
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
                while (n % i == 0)
                    n = n / i;
            }
            if (n > 2)
            {
                Console.WriteLine(n);
            }

        }
    }
}
