using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Qn6
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
            List<item> list2 = new List<item>()
            {
                new item("pencil",23.45),
                new item("box",2300),
                new item("pen",780),
                new item("notes",2200),

            };
            var result = from o in list
                         join e in list2
                         on o.itemname equals e.itemname
                         select new { orderid = o.orderid, itemname = o.itemname, orderdate = o.orderdate, price = e.price = (e.price * o.quantity) };
            var final = result.OrderByDescending(o => o.orderdate.Month).ToList();
            foreach (var item in final)
            {
                Console.WriteLine($"Order id:{item.orderid},ordername:{item.itemname},orderdate:{item.orderdate.ToShortDateString()},price:{item.price}");
            }
        }

    }
    
}
