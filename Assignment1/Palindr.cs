﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Palindr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the word");
            string orginal = Console.ReadLine();
            string reverse = "";
            for (int i = orginal.Length - 1; i >= 0; i--)
            {
                reverse += orginal[i].ToString();

            }
            Console.WriteLine($"the reverse of the world {orginal} is {reverse}");
            if (orginal == reverse)
                Console.WriteLine($"{orginal} is pallindrome");
            else
                Console.WriteLine($"{orginal} is not pallindrome");

        }
    }
}
