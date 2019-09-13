using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionExercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            string[] origin = { "Germany", "Germany", "Japan", "Germany", "Germany", "Germany", "USA" };
            var list = new List<string>();
            var hash = new HashSet<string>();
            var dictionary = new Dictionary<string, string>();
            for (int i = 0; i < array.Length; i++)
            {
                //list.Add(array[i].Substring(object, array[i].IndexOf("->") - 1); 
                list.Add(array[i]);
                hash.Add(array[i]);
                if (!dictionary.ContainsKey(array[i]))
                {
                    dictionary.Add(array[i], origin[i]);
                }
            }

            Console.WriteLine(string.Join(",", list.ToArray()));
            Console.WriteLine(string.Join(",", hash));
            Console.WriteLine(string.Join(", ", dictionary.Select(pair => $"{pair.Key} => {pair.Value}")));


            //todo - replace array with an List and print out the results

            //todo - replace array with a HashSet and print out the results

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
        }


    }
}