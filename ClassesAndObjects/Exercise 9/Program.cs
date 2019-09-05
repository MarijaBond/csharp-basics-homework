using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");

            Swap.SwapPoints(ref p1, ref p2);

            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
        }
        }
    }

