using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Fibanooci
    {
        static void Main()
        {
            long num1 = 0, num2 = 1, sum = 0, count = 40;
            Console.WriteLine("Fibonacci Series till 40: ");
            Console.WriteLine(num1 + " " + num2);
            for (int i = 2; i < count; ++i)
            {
                sum = num1 + num2;
                Console.WriteLine(" " + sum);
                num1 = num2;
                num2 = sum;
            }
        }
    }
}
