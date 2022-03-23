using System;
using ClassTaxi;

namespace Tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi driver1 = new Taxi();

            driver1.DriverName = "Taufik";
            driver1.OnDuty = true;
            driver1.NumPassenger = 5;

            driver1.TaxiInfo();
            Console.WriteLine();
            driver1.PickUpPassenger();
            driver1.PickOffPassenger();

            Console.ReadKey();
        }
    }
}
