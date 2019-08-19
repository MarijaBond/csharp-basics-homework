using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 35;
            int sum = a++ + b++;
            Console.WriteLine(sum);
        }
    }
}
