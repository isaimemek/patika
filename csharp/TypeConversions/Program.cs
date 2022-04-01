using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Fatih";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            // Explicit Conversion

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString Method

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            // System.Covert Class

            string s1 = "10", s2 = "20";
            int num1, num2;
            int toplam;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);
            toplam = num1 + num2;
            Console.WriteLine("toplam: " + toplam);

            // Parse Method
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string text1 = "10";
            string text2 = "10.25";
            int num3;
            double double1;

            num3 = Int32.Parse(clause1);
            Console.WriteLine("num3: " + num3);

            double1 = Double.Parse(clause2);
            Console.WriteLine("double1: " + double1);
        }
    }
}