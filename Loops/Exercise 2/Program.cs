using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input value of i : ");
            i = Convert.ToInt32(Console.ReadLine());
            int result = i;

            for (var a = 1; a <= n - 1; a++)
            {

                result = result * i;

            }

            Console.WriteLine("The result is: " + result);

            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            for (.......) {
              Console.WriteLine(........);
            }
            */
        }
    }
}
