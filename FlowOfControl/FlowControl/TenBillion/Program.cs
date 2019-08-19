using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static long Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Convert.ToInt64(Console.ReadLine());
            var digits = 0;

            if (input < 0)
            {
                return input *= -1;
            }


            if (input >= 10000000000)
            {
                Console.WriteLine("Number is greater or equals 10,000,000,000!");
            }
            else if
            {
                    if (input >= 10 && input <= 99)
                    {
                        digits = 1;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }

                    else if (input >= 10 && input <= 99)
                    {
                        digits = 2;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else if (input >= 100 && input <= 999)
                    {
                        digits = 3;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else if (input >= 1000 && input <= 9999)
                    {
                        digits = 4;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else if (input >= 10000 && input <= 99999)
                    {
                        digits = 5;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else if (input >= 100000 && input <= 999999)
                    {
                        digits = 6;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else if (input >= 1000000 && input <= 9999999)
                    {
                        digits = 7;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else if (input >= 10000000 && input <= 99999999)
                    {
                        digits = 8;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else if (input >= 100000000 && input <= 999999999)
                    {
                        digits = 9;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                    else
                    {
                        digits = 10;
                        Console.WriteLine("Number of digits in the number: " + digits);
                    }
                }

                else {
                    Console.WriteLine("The number is not a long");
                }
            
        }

    }
}

