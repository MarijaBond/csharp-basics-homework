using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_5
{
    class Date
    {
        private string _month;
        private int _day;
        private int _year;

        public Date(string aMonth, int aDay, int aYear) {
            Month = aMonth;
            Day = aDay;
            Year = aYear;
        }
        public string Month
        {
            get
            {
                return this._month;
            }
            set
            {
                if (value == "January" || value == "February" || value == "March" ||
                    value == "April" || value == "May" || value == "June" ||
                    value == "July" || value == "August" || value == "September" ||
                    value == "October" || value == "November" || value == "December")
                {
                    this._month = value;
                }
                else
                {
                    this._month = "undefined";
                }
            }
        }
        public int Day
        {
            get { return this._day;  }
            set { if (value >= 1 && value <= 31)
                {
                    this._day = value;
                }
                else { Console.WriteLine("Failure"); }
            } }
                       

        public int Year
        {
            get { return this._year; }
            set
            {
                if (value >= 1990 && value <= 2019)
                {
                    this._year = value;
                }
                else { Console.WriteLine("Failure"); }
            }
        }


        public void DisplayDate ()
        {
            Console.WriteLine(this._month + " / " + this._day + " / " + this._year + " / ");
        }
    }
}
