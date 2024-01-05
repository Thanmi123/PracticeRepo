using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    
    internal class Qn4
    {
        static void Main(string[] args)
        {
            List<Order> list = new List<Order>()
            {
                new Order(1,"pencil",new DateTime(2001,02,25),89),
                new Order(2,"box",new DateTime(2000,12,25),890),
                new Order(3,"pen",new DateTime(1900,7,10),189),
                new Order(4,"notes",new DateTime(2020, 9, 5),809),
            };
            /*var result = from i in list
                         orderby i.orderdate descending
                         group i by i.orderdate.Month;
            *//*select i;*//*
            foreach (var f in result)
            {
                Console.WriteLine("orders month " + f.Key );
                foreach (var item in f)
                {
                    Console.WriteLine($"ordername:{item.itemname}");
                }
            }*/
            var result = list.OrderByDescending(i => i.orderdate.Month);
            foreach (var item in result)
            {
                Console.WriteLine($"Order id:{item.orderid},ordername:{item.itemname},orderdate:{item.orderdate.ToShortDateString()},quantity:{item.quantity}");
            }

        }
    }
   
}
