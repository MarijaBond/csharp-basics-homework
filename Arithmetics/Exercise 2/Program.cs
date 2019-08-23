using System;

namespace Arithm2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{CheckOddEven(5)} \nBye!");


            string CheckOddEven(int a)
            {
                if (a % 2 != 0)
                {
                    return "Odd Number";
                }

                else
                {
                    return "Even Number";
                }


            }
        }
    }
}
