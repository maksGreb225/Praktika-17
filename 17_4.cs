using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_17_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Weather { City = "Москава", Temp = 22.5 };
            var w2 = new Weather { City = "Сочи", Temp = null };
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w2 .Temp ?? -999);
        }
    }

    struct Weather
    {
        public string City;
        public double? Temp;

        public Weather(string city, double temp)
        {
            this.City = city;
            this.Temp = temp;
        }

        public override string ToString() {
            if (Temp == null)
                return City + ": Нет данных";
            else
            return City + " " + Temp;
        }
    }
}
