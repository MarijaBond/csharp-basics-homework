using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_4_
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            this._title = title;
            this._studio = studio;
            this._rating = rating;
        }
        public Movie(string title, string studio)
        {
            while (_rating == "PG")
            {
                this._title = title;
                this._studio = studio;
            }
        }

        public static void GetPG ()
        {

            string[][] movieArray = new string[8][];
            movieArray[0] = new string[] { "Harry Potter and the Sorcerers Stone", "Warner Brothers", "PG" };
            movieArray[1] = new string[] { "Harry Potter Part2", "Warner Brothers", "PG" };
            movieArray[2] = new string[] { "Harry Potter Part3", "Warner Brothers", "PG-13" };
            movieArray[3] = new string[] { "Harry Potter Part4", "Warner Brothers", "PG-13" };
            movieArray[4] = new string[] { "Harry Potter Part5", "Warner Brothers", "NC-17" };
            movieArray[5] = new string[] { "Harry Potter Part6", "Warner Brothers", "NC-17" };
            movieArray[6] = new string[] { "Harry Potter Part7A", "Warner Brothers", "R" };
            movieArray[7] = new string[] { "Harry Potter Part7B", "Warner Brothers", "R" };

            string[][] onlyPG = new string[8][];


            onlyPG = movieArray.Where(c => c != null && c[2] == "PG").ToArray();

            Console.WriteLine("The movies with a PG rating are: ");
            for (var i = 0; i < onlyPG.Length; i++)
            {
                Console.WriteLine(string.Join(", ", onlyPG[i]));
            }
            }

    }
}
