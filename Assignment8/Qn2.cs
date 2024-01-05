using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Player
    {
        public Player(string name, string country)
        {
            this.name = name;
            this.country = country;
        }
        public string name { get; set; }
        public string country { get; set; }
    }
    internal class Qn2
    {
        static void Main(string[] args)
        {
            List<Player> list = new List<Player>()
            {
                new Player("Player1","India"),
                new Player("Player2", "USA"),
            };

            List<Player> list2 = new List<Player>()
            {
                new Player("Player3","India"),
                new Player("Player4", "UK"),
            };
            var result = from l1 in list
                         from l2 in list2
                         where l1.country != l2.country
                         select new { op = l1.name, op1 = l2.name };//merging 2 list into one by creating object
            foreach (var p in result)
                Console.WriteLine($"{p.op}*{p.op1}");
        }

    }
}
