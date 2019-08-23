using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDayInWord(3);
        }


        static void PrintDayInWord (int dayNumber) { 
                switch (dayNumber)
                {
                    case 0:
                        Console.WriteLine("It's Sunday!");
                        break;
                    case 1:
                        Console.WriteLine("It's Monday!");
                        break;
                    case 2:
                        Console.WriteLine("It's Tuesday!");
                        break;
                    case 3:
                        Console.WriteLine("It's Wednesday!");
                        break;
                    case 4:
                        Console.WriteLine("It's Thursday!");
                        break;
                    case 5:
                        Console.WriteLine("It's Friday!");
                        break;
                    case 6:
                        Console.WriteLine("It's Saturday!");
                        break;

                }
            }
        }
    }
