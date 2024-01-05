using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    /*class Order1
    {
        public Order1(int orderid, string itemname, DateTime orderdate, int quantity)
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
    }*/
    class item
    {
        public item(string itemname,double price)
        {
            this.itemname = itemname;
            this.price = price;
        }
        public string itemname { get; set; }
        public double price { get; set; }
    }
    class Final
    {
        public Final(int orderid, string itemname, DateTime orderdate, double price)
        {
            this.orderid = orderid;
            this.itemname = itemname;
            this.orderdate = orderdate;
            this.price = price;
        }
        public int orderid { get; set; }
        public string itemname { get; set; }
        public DateTime orderdate { get; set; }
        public double price { get; set; }
    }
    internal class Qn5
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
                         select new Final(o.orderid, o.itemname, o.orderdate, e.price=(e.price * o.quantity));
            var final=result.OrderByDescending(o => o.orderdate.Month).ToList();
            foreach(var item in final)
            {
                Console.WriteLine($"Order id:{item.orderid},ordername:{item.itemname},orderdate:{item.orderdate.ToShortDateString()},price:{item.price}");
            }
        }
    }
}
