using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Order
    {
        public Order(int orderid, string itemname, DateTime orderdate, int quantity)
        {
            this.orderid = orderid;
            this.itemname = itemname;
            this.orderdate = orderdate;
            this.quantity = quantity;
        }
        public int orderid { get; set; }
        public string itemname { get; set; }
        public DateTime orderdate { get; set; }
        public int quantity { get; set; }
    }
    internal class Qn3
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
            var result = from i in list 
                         orderby i.orderdate descending
                         select i;
            foreach (var item in result)
            {
                Console.WriteLine($"Order id:{item.orderid},ordername:{item.itemname},orderdate:{item.orderdate.ToShortDateString()},quantity:{item.quantity}");

            }
            Console.WriteLine("By quality wise");
            var result1= from i in list
                         orderby i.quantity descending
                         select i;
            foreach(var item in result1)
            {
                Console.WriteLine($"Order id:{item.orderid},ordername:{item.itemname},orderdate:{item.orderdate.ToShortDateString()},quantity:{item.quantity}");
            }


        }
    }
}
