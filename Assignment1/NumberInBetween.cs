using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class NumberInBetween
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                if (i != n1 && i != n2)
                {
                    Console.WriteLine(i);
                }

            }
           /* //or
            for (int i = n1 + 1; i < n2; i++)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
