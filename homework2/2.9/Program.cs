using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            bool[] isPrimes = new bool[num + 1];
            int sqrtn = (int)Math.Sqrt(num);

            for (int i = 2; i <= num; i++)
                isPrimes[i] = true;

            for (int i = 2; i <= sqrtn; i++)
            {
                if (isPrimes[i] == true)
                {
                    for (int j = 2; j <= num; j++)
                    {
                        if (j % i == 0 && i != j)
                            isPrimes[j] = false;
                    }
                }
            }
            Console.WriteLine("100以内的素数:");
            for (int j = 2; j <= num; j++)
            {
                if (isPrimes[j] == true)
                    Console.Write(j + " ");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
