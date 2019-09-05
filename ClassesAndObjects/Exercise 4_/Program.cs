using System;
using System.Linq;

namespace Exercise_4_
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie.GetPG();

            Movie casinoRoyale = new Movie ("Casino Royale", "Eon Productions", "PG­13");

            Movie glass = new Movie ("Glass", "Buena Vista International", "PG­13");

            Movie spiderMan = new Movie ("Spider - Man: Into the Spider - Verse", "Columbia Pictures", "PG");

        }
    }
}
