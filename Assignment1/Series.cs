using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Series
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 25; i++)
            {
                int j = i * i;
                Console.Write(j + ",");
            }
        }
    }
}
