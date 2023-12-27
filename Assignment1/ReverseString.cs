using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("enter the word");
            string orginal = Console.ReadLine();
            string reversed = "";
            for (int i = orginal.Length - 1; i >= 0; i--)
            {
                reversed += orginal[i].ToString();

            }
            Console.WriteLine($"the reverse of the world {orginal} is {reversed}");
        }
    }
}
