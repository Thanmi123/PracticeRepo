using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Equalornot
    {
        static void Main()
        {
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are not the same.");
            }
        }
    }
}
