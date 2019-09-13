using System;

namespace ConsoleApp2
{
    class NumberSquare
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a first number from 1 to 10 (min)");
            int point = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number from 1 to 10 (max)");
            int x = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < x; i++)

            {

                for (int k = point; k <= x; k++)

                {

                    Console.Write(k);

                }

                for (int j = 1; j < point; j++)

                {

                    Console.Write(j);

                }

                point++;

                Console.WriteLine();

            }
        }
    }
}
