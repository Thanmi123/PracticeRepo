using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Qn1
    {
        static void Main(string[] args)
        {
            int[] n = { 7,8,5,6 };
            var result=from k in n
                       let i = k * k * k
                       where i>100&&i<1000
                       select i;
            foreach(var j in result)
            {
                Console.WriteLine(j);
            }

        }
    }
}
