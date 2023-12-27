using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Smallest
    {
        static void Main(string[] args)
        {
            int[] small = new int[5];
            Console.WriteLine("enter 5 numbers : ");
            for (int i = 0; i < small.Length; i++)
            {
                small[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest;
            for (int i = 0; i < small.Length; i++)
            {
                smallest = small[i];
                for (int j2 = 1; j2 < small.Length; j2++)
                {

                    if ((smallest < small[j2]) || (smallest == small[j2]))
                    {
                        continue;
                    }
                    else
                    {
                        smallest = small[j2];
                    }
                }
                Console.WriteLine("the smallest number is " + smallest);
                break;
            }


        }
    }
}
