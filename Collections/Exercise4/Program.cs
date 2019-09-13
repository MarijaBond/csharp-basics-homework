using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string> { };

            while (true)
            {
                Console.WriteLine("Enter name!");
                string input = Console.ReadLine();
                if (input != string.Empty)
                {
                    names.Add(input);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", names));
        }
    }
}
