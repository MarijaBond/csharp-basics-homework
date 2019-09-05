using System;

namespace Exercise_7
{
    class DogTest
    {
        static void Main(string[] args)
        {

            Dog max = new Dog("Max", "male", "Lady", "Rocky");
            Dog rocky = new Dog("Rocky", "male", "Molly", "Sam");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male", "Lady", "Sparkey");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female", "Molly", "Buster");

            coco.FathersName();
            sparky.FathersName();

            if (rocky.HasSameMotherAs(coco))
            {
                Console.WriteLine("Have same father");
            }
            else
            {
                Console.WriteLine("Different fathers");
            }



        }
    }
}
