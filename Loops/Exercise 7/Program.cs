using System;

namespace Exercise_7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            int i;
            int userPoints = 0;

            Random x = new Random();
            int luckyNumberThrown = x.Next(1, 7);

            if (luckyNumberThrown == 1)
            {
                Console.WriteLine("The game is over!");
            }
            else
            {
                for (i = 0; i < 100; i++)
                {
                    Console.WriteLine("You have thrown: " + luckyNumberThrown);
                    userPoints = userPoints + luckyNumberThrown;
                    Console.WriteLine("Your total points are: " + userPoints);
                    Console.WriteLine("Do you want to continue? Answer \"true\" or \"false\"");
                    bool userDecision = Convert.ToBoolean(Console.ReadLine());
                    if (userDecision == false || luckyNumberThrown == 1)
                    {
                        Console.WriteLine("The game is over!");
                    }
                    else
                    {
                        Random y = new Random();
                        int newLuckyNumberThrown = y.Next(1, 7);
                        luckyNumberThrown = newLuckyNumberThrown;
                        continue;
                    }
                }
            }
            
        }
    }
    }

