using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Marks
    {
        static void Main(string[] args)
        {


            int[] marks = new int[5];
            int total = 0, avg = 0, min = 0, max = 0;/*temp=0*/
            Console.Write("enter the marks: ");
            for (int i = 0; i < marks.Length; i++)
            {
                /*Console.Write($"{i})");*/
                marks[i] = Convert.ToInt32(Console.ReadLine());
                /*Console.WriteLine("hi");*/
            }
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }
            Console.WriteLine("total marks : " + total);
            avg = total / marks.Length;
            Console.WriteLine("Average mark : " + avg);

            max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }
            min = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }
            Console.WriteLine($"Max is: {max} and min is : {min}");
            Array.Sort(marks);

            Console.WriteLine("The ascending order: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);

            }
            Array.Reverse(marks);
            Console.WriteLine("The descending order: " + ",");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);

            }
        }
    }
}
