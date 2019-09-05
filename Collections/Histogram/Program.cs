using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = "../Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {

            //ArrayList grades = new ArrayList();
            var readText = File.ReadAllLines(Path);
            string[] gradesArray = new string[readText.Length];

            foreach (var s in readText)
            {
                Console.WriteLine(s);
                s.Split(' ');
                gradesArray = s.Split(" ");               
            }
            //Console.WriteLine(string.Join(",", gradesArray));
            var gradesDictionary = new Dictionary<string, IList<int>>();
            IList<int> myList0 = new List<int>();
            IList<int> myList1 = new List<int>();
            IList<int> myList2 = new List<int>();
            IList<int> myList3 = new List<int>();
            IList<int> myList4 = new List<int>();
            IList<int> myList5 = new List<int>();
            IList<int> myList6 = new List<int>();
            IList<int> myList7 = new List<int>();
            IList<int> myList8 = new List<int>();
            IList<int> myList9 = new List<int>();
            IList<int> myList10 = new List<int>();

            for (var i = 0; i < gradesArray.Length; i++ )
            {
                if (Convert.ToInt32(gradesArray[i]) >= 0 && (Convert.ToInt32(gradesArray[i]) < 10))
                {
                    myList0.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 10 && (Convert.ToInt32(gradesArray[i]) < 20))
                {
                    myList1.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 20 && (Convert.ToInt32(gradesArray[i]) < 30))
                {
                    myList2.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 30 && (Convert.ToInt32(gradesArray[i]) < 40))
                {
                    myList3.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 40 && (Convert.ToInt32(gradesArray[i]) < 50))
                {
                    myList4.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 50 && (Convert.ToInt32(gradesArray[i]) < 60))
                {
                    myList5.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 60 && (Convert.ToInt32(gradesArray[i]) < 70))
                {
                    myList6.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 70 && (Convert.ToInt32(gradesArray[i]) < 80))
                    {
                        myList7.Add(Convert.ToInt32(gradesArray[i]));
                    }
                else if (Convert.ToInt32(gradesArray[i]) >= 80 && (Convert.ToInt32(gradesArray[i]) < 90))
                {
                    myList8.Add(Convert.ToInt32(gradesArray[i]));
                }
                else if (Convert.ToInt32(gradesArray[i]) >= 90 && (Convert.ToInt32(gradesArray[i]) < 100))
                {
                    myList9.Add(Convert.ToInt32(gradesArray[i]));
                }
                else { myList10.Add(Convert.ToInt32(gradesArray[i])); }
            }
            //Console.Write(string.Join(",", myList2));

            gradesDictionary["Range 00-09"] = myList0;
            gradesDictionary["Range 10-19"] = myList1;
            gradesDictionary["Range 20-29"] = myList2;
            gradesDictionary["Range 30-39"] = myList3;
            gradesDictionary["Range 40-49"] = myList4;
            gradesDictionary["Range 50-59"] = myList5;
            gradesDictionary["Range 60-69"] = myList6;
            gradesDictionary["Range 70-79"] = myList7;
            gradesDictionary["Range 80-89"] = myList8;
            gradesDictionary["Range 90-99"] = myList9;
            gradesDictionary["Range 100"] = myList10;

            int count_00_09 = gradesDictionary["Range 00-09"].Count();
            int count_10_19 = gradesDictionary["Range 10-19"].Count();
            int count_20_29 = gradesDictionary["Range 20-29"].Count();
            int count_30_39 = gradesDictionary["Range 30-39"].Count();
            int count_40_49 = gradesDictionary["Range 40-49"].Count();
            int count_50_59 = gradesDictionary["Range 50-59"].Count();
            int count_60_69 = gradesDictionary["Range 60-69"].Count();
            int count_70_79 = gradesDictionary["Range 70-79"].Count();
            int count_80_89 = gradesDictionary["Range 80-89"].Count();
            int count_90_99 = gradesDictionary["Range 90-99"].Count();
            int count_100 = gradesDictionary["Range 100"].Count();

            /* foreach (var contents in gradesDictionary.Keys)
             {

                 foreach (var listMember in gradesDictionary[contents])
                 {
                     Console.WriteLine("Key : " + contents + " member :" + listMember);
                 }
             }*/


            string[] histogram_00_09 = new String('+', count_00_09).Replace("+", "*").Split(',');
            string[] histogram_10_19 = new String('+', count_10_19).Replace("+", "*").Split(',');
            string[] histogram_20_29 = new String('+', count_20_29).Replace("+", "*").Split(',');
            string[] histogram_30_39 = new String('+', count_30_39).Replace("+", "*").Split(',');
            string[] histogram_40_49 = new String('+', count_40_49).Replace("+", "*").Split(',');
            string[] histogram_50_59 = new String('+', count_50_59).Replace("+", "*").Split(',');
            string[] histogram_60_69 = new String('+', count_60_69).Replace("+", "*").Split(',');
            string[] histogram_70_79 = new String('+', count_70_79).Replace("+", "*").Split(',');
            string[] histogram_80_89 = new String('+', count_80_89).Replace("+", "*").Split(',');
            string[] histogram_90_99 = new String('+', count_90_99).Replace("+", "*").Split(',');
            string[] histogram_100 = new String('+', count_100).Replace("+", "*").Split(',');


            Console.WriteLine("00-09: " + string.Join("", histogram_00_09));
            Console.WriteLine("10-19: " + string.Join("", histogram_10_19));
            Console.WriteLine("20-29: " + string.Join("", histogram_20_29));
            Console.WriteLine("30-39: " + string.Join("", histogram_30_39));
            Console.WriteLine("40-49: " + string.Join("", histogram_40_49));
            Console.WriteLine("50-59: " + string.Join("", histogram_50_59));
            Console.WriteLine("60-69: " + string.Join("", histogram_60_69));
            Console.WriteLine("70-79: " + string.Join("", histogram_70_79));
            Console.WriteLine("80-89: " + string.Join("", histogram_80_89));
            Console.WriteLine("90-99: " + string.Join("", histogram_90_99));
            Console.WriteLine("100:   " + string.Join("", histogram_100));


        }
    }

    }
            
        