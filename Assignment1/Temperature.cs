using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Temperature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature in Fahrenheit: ");
            double Fahrenheit = Convert.ToInt32(Console.ReadLine());
            double Celsius = ((Fahrenheit - 32)) / (1.8);
            Console.WriteLine(Celsius);
        }
    }
}
