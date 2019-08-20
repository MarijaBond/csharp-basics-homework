using System;

namespace test_Tuesd
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.84667;
            string b = a.ToString("0.###");
            Console.WriteLine($"{a:0.###}");
            var c = a.ToString("0.##");
            Console.WriteLine(c);

            double d = System.Math.Round(a, 4);
            Console.WriteLine(d);



        }
    }
}
