using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the input number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 20; i++)
            {
                int j = i * input;
                Console.WriteLine(i + " * " + input + " = " + j);
            }
        }
    }
}
