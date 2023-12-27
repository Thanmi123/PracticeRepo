using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Oddoreven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());  
            if(number%2==0)
            {
                Console.WriteLine(number + " is an even");
            }
            else
            {
                Console.WriteLine(number + " is odd ");
            }

        }
    }
}
