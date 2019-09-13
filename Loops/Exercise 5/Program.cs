using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter second word");
            string input2 = Console.ReadLine();

            Console.WriteLine(input1.Length + input2.Length);

                if ((input1.Length + input2.Length) < 30)
                {
                    int a = 30 - (input1.Length + input2.Length);
                    string b = String.Concat(System.Linq.Enumerable.Repeat(".", a));
                    Console.WriteLine(input1 + b + input2);
                }
                else
                {
                    Console.WriteLine("Your input is too long! The sum of letters must be less than 30 characters");
                }

        }
    }
}
