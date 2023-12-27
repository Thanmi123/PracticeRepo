using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of the number is: " + factorial);
        }
    }
}
