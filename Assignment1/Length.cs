using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Length
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a word:");
                string word = Console.ReadLine();

                int length = word.Length;

                Console.WriteLine("The length of the word is: " + length);
            }
        }
    }
}
