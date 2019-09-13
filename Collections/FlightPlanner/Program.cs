using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            HashSet<string> originCities = new HashSet<string>();
            //(StringComparer.InvariantCultureIgnoreCase);
            HashSet<string> destinationCities = new HashSet<string>();
            //(StringComparer.InvariantCultureIgnoreCase);
            List<KeyValuePair<string, string>> connectingCities = new List<KeyValuePair<string, string>>();          //!!!

            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                //Console.WriteLine(s);
                string singleRoute = Convert.ToString(s);
                char[] a = singleRoute.ToCharArray();
                int b = Array.IndexOf(a, '>');

                char[] originArray = singleRoute.ToCharArray(0, b - 2);
                char[] destinationArray = singleRoute.ToCharArray(b + 2, singleRoute.Length - (b + 2));
                string origin = String.Join("", originArray);
                string destination = String.Join("", destinationArray);
                originCities.Add(origin);
                destinationCities.Add(destination);

                connectingCities.Add(new KeyValuePair<string, string>(origin, destination)); // !!!! - a collection of key-value pairs which ALLOWS duplicates
                //Console.WriteLine(string.Join(",", connectingCities));
            }

            Console.WriteLine("Welcome to CODELEX AIRLINES!\n");

            Console.WriteLine("Flyinng from: ");
            foreach (string obj in originCities)
            {
                Console.Write("{0} \n", obj);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Flying to: ");
            foreach (string obj in destinationCities)
            {
                Console.Write("{0} \n", obj);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Choose your origin city!");
            string userOrigin = Console.ReadLine();
            if (!originCities.Contains(userOrigin))
            {
                Console.WriteLine("Please enter a valid city from the list");
                userOrigin = Console.ReadLine();
            }

            if (originCities.Contains(userOrigin))
            {
                Console.WriteLine("Destinations available from " + userOrigin + ":");
            }

            foreach (KeyValuePair<string, string> pair in connectingCities)
            {
                if (pair.Key.Contains(userOrigin))
                { Console.WriteLine(pair.Value); }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Choose your destination city!");
            string userDestination = Console.ReadLine();

            Console.WriteLine("The route that was chosen: " + userOrigin + " -> " + userDestination);





        }   
    }
}