using System;
using System.Collections;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        private static void Main(string[] args)
        {
            PhoneDirectory myDirectory = new PhoneDirectory("Marija B.", "22222222");
            myDirectory.PutNumber("Jon Snow", "999999999");
            myDirectory.PrintPhoneDirectory();
            myDirectory.GetNumber("Marija B.");
           


        }
    }
}