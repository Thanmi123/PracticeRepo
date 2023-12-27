using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Largest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");

            Console.Write("Number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine($"The largest number is: {a}");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine($"The largest number is: {b}");
            }
            else
            {
                Console.WriteLine($"The largest number is: {c}");
            }


        }  
      
           
        }
    }