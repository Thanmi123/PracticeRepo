using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class NumberOddorEven
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("enter the numbers max 6 : ");
            int even, odd;
            even = odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("even no's were : " + even);
            Console.WriteLine("odd no's were : " + odd);
        }
    }
}
