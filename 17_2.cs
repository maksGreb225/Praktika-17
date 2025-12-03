using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order { ID = 1001, Total = 1500.50m };
            var order2 = order1;
            order2.Total = 2000.00m;
            Console.WriteLine(order1.Total);
        }
    }

    class Order {
        public int ID;
        public decimal Total;

        public Order() { }

        public Order(int ID, decimal Total) {
            this.ID = ID;
            this.Total = Total;
        }
    }
}
