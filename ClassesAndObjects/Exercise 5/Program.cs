using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date myBirthDay = new Date("April", 19, 1991);
            myBirthDay.DisplayDate();
            Console.WriteLine(myBirthDay.Day);
        }
    }
}
