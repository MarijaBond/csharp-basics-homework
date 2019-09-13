using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a number to check whether it is Happy!");
            int n = Convert.ToInt32(Console.ReadLine());
            int userInput = n;
            int sum = 0;
            int check = 0;
            while (n != 1)
            {
                numbers.Add(n);
                Console.WriteLine(string.Join(",", numbers));
                check += 1;
                while (n != 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }
                n = sum;
                sum = 0;
                if (check > 10) { break;  }
                
            }
            if (check <= 10)
            {
                Console.WriteLine("Number " + userInput + " is Happy!");
            }
            else {
                Console.WriteLine("Number " + userInput + " is not Happy!"); }
        }
    }
}