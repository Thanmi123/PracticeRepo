using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Pallindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the word");
            string word = Console.ReadLine();
            string reverse = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i].ToString();

            }
            if (word == reverse)
                Console.WriteLine($"{word} is pallindrome");
            else
                Console.WriteLine($"{word} is not pallindrome");

        }
    }
}
