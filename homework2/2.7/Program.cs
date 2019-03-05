using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 13, 56, 82, 64, 48, 50, 49, 17, 37, 81 };
            int max = 0, min = 100, sum=0, ave;
            Console.Write("数组元素:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + " ");
                sum += numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }
            ave = sum / 10;
            Console.WriteLine("");
            Console.WriteLine("最大值:" + max);
            Console.WriteLine("最小值:" + min);
            Console.WriteLine("平均值:" + ave);
            Console.WriteLine("总和:" + sum);
        }
    }
}
