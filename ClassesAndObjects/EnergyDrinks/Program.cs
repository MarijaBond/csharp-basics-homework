using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{

    class SoftDrinksSurvey
    {
        private int _numberedSurveyed;
        private double _purchasedEnergyDrinks;
        private double _preferCitrusDrinks;

        public int NumberedSurveyed { get => _numberedSurveyed; set => _numberedSurveyed = value; }
        public double PurchasedEnergyDrinks { get => _purchasedEnergyDrinks; set => _purchasedEnergyDrinks = value; }
        public double PreferCitrusDrinks { get => _preferCitrusDrinks; set => _preferCitrusDrinks = value; }

        public SoftDrinksSurvey(int peopleSurveyed, double drinkOnceAWeek, double preferCitrus)
        {
            this._numberedSurveyed = peopleSurveyed;
            this._purchasedEnergyDrinks = drinkOnceAWeek;
            this._preferCitrusDrinks = preferCitrus;
        }

        public void PrintSoftDrinks ()
        {
            Console.WriteLine("Total number of people surveyed " + this._numberedSurveyed);
        }
        public void CalculateEnergyDrinkers()
        {
            Console.WriteLine("Approximately " + ((double)this._numberedSurveyed * this._purchasedEnergyDrinks).ToString("0.") + " bought at least one energy drink");
        }

        public void CalculatePreferCitrus()
        {
           Console.WriteLine(((double)this._numberedSurveyed * this._purchasedEnergyDrinks * this._preferCitrusDrinks).ToString("0.") + " of those " + "prefer citrus flavored energy drinks.");
        }
    }

    class Program {
        private static void Main(string[] args)
        {

            SoftDrinksSurvey SurveyOf2019 = new SoftDrinksSurvey(12467, 0.14, 0.64);

            SurveyOf2019.PrintSoftDrinks();
            SurveyOf2019.CalculateEnergyDrinkers();
            SurveyOf2019.CalculatePreferCitrus();
            
        }
    }
}
