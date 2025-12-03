using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Color(255, 128, 0);
            var c2 = c1;
            c2.R = 100;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }

    struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public override string ToString() { 
            return $"RGB({R}, {G}, {B})";
        }
    }
}
